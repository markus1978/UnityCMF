package com.cubemonstergames.unitycmf.generators

import com.google.inject.Singleton
import org.eclipse.emf.ecore.EEnum
import org.eclipse.emf.ecore.EPackage
import org.eclipse.emf.ecore.EcorePackage

@Singleton
class MetaGenerator extends AbstractGenerator {

	def generateMeta(EPackage ePackage) '''
		using UnityCMF.CCore;
		«IF ePackage != EcorePackage.eINSTANCE»
			using UnityCMF.ECore;
		«ENDIF»
		
		namespace «ePackage.cNamespaceName» {
			«FOR eEnum:ePackage.EClassifiers.filter[c|c instanceof EEnum]»
				public enum «eEnum.name» { «FOR literal:(eEnum as EEnum).ELiterals SEPARATOR ", "»«literal.name»«ENDFOR» }
			«ENDFOR»
			
			«ePackage.generateMetaClass»
			«ePackage.generatePackageInterface»
			«ePackage.generatePackageImplementation»
			«ePackage.generateFactoryInterface»
			«ePackage.generateFactoryImplementation»
			
		} // «ePackage.cNamespaceName»
	'''
	
	def generateMetaClass(EPackage ePackage) '''
		public sealed class «ePackage.cMetaName» {
			public static «ePackage.cMetaName» cINSTANCE = new «ePackage.cMetaName»();
			private «ePackage.cPackageImplementationName» _package = new «ePackage.cPackageImplementationName»();
			private «ePackage.cFactoryImplementationName» _factory = new «ePackage.cFactoryImplementationName»();
			public «ePackage.cPackageInterfaceName» Package { 
				get {
					_package.init();
					return _package;
				}
			}
			public «ePackage.cFactoryInterfaceName» Factory { 
				get {
					return _factory;
				} 
			}
		}
	'''
	
	def generatePackageInterface(EPackage ePackage) '''
		public interface «ePackage.cPackageInterfaceName» : CPackage {
			«FOR eClassifier:ePackage.EClassifiers»
				«modelGenerator.classifierGenerator.generatatePackageInterfacePropertyDefinition(eClassifier)»
			«ENDFOR»
		}
	'''
	
	def generatePackageImplementation(EPackage ePackage) '''
		public class «ePackage.cPackageImplementationName» : «ePackage.cPackageRef» {
			public CFactory FactoryInstance {
				get {
					return «cFactoryInstanceRef(ePackage)»;
				}	
			}
			
			private bool _isInited = false;
			
			public void init() {
				if (_isInited) return;
				_isInited = true;				
				«FOR eClassifier:ePackage.EClassifiers»
					«modelGenerator.classifierGenerator.generatatePackageImplementationClassifierInitialization(eClassifier)»
				«ENDFOR»
				«FOR eClassifier:ePackage.EClassifiers»
					«modelGenerator.classifierGenerator.generatatePackageImplementationFeatureInitialization(eClassifier)»
				«ENDFOR»
			}
			
			«FOR eClassifier:ePackage.EClassifiers»
				«modelGenerator.classifierGenerator.generatatePackageImplementationPropertyImplementation(eClassifier)»				
			«ENDFOR»
			
			public EClassifier getClassifier(string name) {
				switch(name) {
					«FOR eClassifier:ePackage.EClassifiers»
						case "«eClassifier.name»": return «modelGenerator.classifierGenerator.cInstanceRef(eClassifier)»;
					«ENDFOR»
					default: return null;	
				}	
			}
		}
	'''
	
	def generateFactoryImplementation(EPackage ePackage) '''
		public class «ePackage.cFactoryImplementationName» : «ePackage.cFactoryInterfaceName» {
			public CPackage PackageInstance {
				get {
					return «cPackageInstanceRef(ePackage)»;
				}	
			}
			
			«FOR eClassifier:ePackage.EClassifiers»
				«modelGenerator.classifierGenerator.generateFactoryImplementation(eClassifier)»
			«ENDFOR»
			
			public CObject create(EClass eClass) {
				switch(eClass.Name) {
					«FOR eClassifier:ePackage.EClassifiers»
						«classifierGenerator.generateFactoryReflectiveImplementation(eClassifier)»
					«ENDFOR»
					default: return null;	
				}	
			}
		}
	'''
	
	def generateFactoryInterface(EPackage ePackage) '''
		public interface «ePackage.cFactoryInterfaceName» : CFactory {
			«FOR eClassifier:ePackage.EClassifiers»
				«modelGenerator.classifierGenerator.generateFactoryInterface(eClassifier)»				
			«ENDFOR»
		}
	'''
	
	
	def cName(EPackage ePackage) {
		if (ePackage == EcorePackage.eINSTANCE) {
			return "ECore";
		} else if ("ccore".equals(ePackage.name)) {
			return "CCore";
		} else {
			return ePackage.name.toFirstUpper;
		}
	}
	
	private def cMetaName(EPackage ePackage) '''«ePackage.cName»Meta'''	
	
	def cMetaClassRef(EPackage ePackage) {
		if (ePackage == modelGenerator.model) {
			return ePackage.cMetaName;
		} else {
			return '''«ePackage.cNamespaceRef».«ePackage.cMetaName»'''
		}
	}
	
	def cNamespaceName(EPackage ePackage) '''UnityCMF.«cName(ePackage)»'''
	
	def cNamespaceRef(EPackage ePackage) { cNamespaceName(ePackage) }
	
	private def cPackageInterfaceName(EPackage ePackage) '''«ePackage.cName»Package'''
	
	private def cPackageImplementationName(EPackage ePackage) '''«ePackage.cPackageInterfaceName»Impl'''
	
	private def cFactoryInterfaceName(EPackage ePackage) '''«ePackage.cName»Factory'''
	
	private def cFactoryImplementationName(EPackage ePackage) '''«ePackage.cFactoryInterfaceName»Impl'''
	
	def cPackageRef(EPackage ePackage) {
		if (ePackage == modelGenerator.model) {
			return ePackage.cPackageInterfaceName;
		} else {
			return '''«ePackage.cNamespaceRef».«ePackage.cPackageInterfaceName»'''
		}
	}
	
	def cFactoryRef(EPackage ePackage) {
		if (ePackage == modelGenerator.model) {
			return ePackage.cFactoryInterfaceName;
		} else {
			return '''«ePackage.cNamespaceRef».«ePackage.cFactoryInterfaceName»'''
		}
	}
	
	def cPackageInstanceRef(EPackage ePackage) '''«ePackage.cMetaClassRef».cINSTANCE.Package'''
	
	def cPackageInstanceRefFromPackageImplementation(EPackage ePackage) '''«IF ePackage == modelGenerator.model»this«ELSE»«ePackage.cPackageInstanceRef»«ENDIF»'''
	
	def cFactoryInstanceRef(EPackage ePackage) '''«ePackage.cMetaClassRef».cINSTANCE.Factory'''
}