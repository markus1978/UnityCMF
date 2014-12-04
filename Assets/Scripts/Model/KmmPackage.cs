�IF ePackage != EcorePackage.eINSTANCE�
	using UnityCMF.ECore;
�ENDIF�

namespace �ePackage.fullPackageName� {			 
	public sealed class �ePackage.metaName� {
		public static �ePackage.metaName� cINSTANCE = new �ePackage.metaName�();
		public �ePackage.packageInterfaceName� Package { get; private set; }
		public �ePackage.factoryInterfaceName� Factory { get; private set; }
		public �ePackage.metaName�() {
			Package = new �ePackage.packageImplementationName�();
			Factory = new �ePackage.factoryImplementationName�();
		}
	}
	
	public interface �ePackage.packageInterfaceName� {
		�FOR eClassifier:ePackage.EClassifiers�
			�IF eClassifier instanceof EClass�
				�(eClassifier as EClass).generatePropertiesForClassInterface�
			�ELSE�
				�(eClassifier as EDataType).generatePropertiesForDataTypeInterface�
			�ENDIF�
		�ENDFOR�
	}
	
	public class �ePackage.packageImplementationName� : �ePackage.packageInterfaceName� {
		public �ePackage.packageImplementationName�() {
			�FOR eClassifier:ePackage.EClassifiers�
				�IF eClassifier instanceof EClass�
					�(eClassifier as EClass).generatePropertiesForClassInitialization�
				�ELSE�
					�(eClassifier as EDataType).generatePropertiesForDataTypeInitialization�
				�ENDIF�
			�ENDFOR�
		}
		
		�FOR eClassifier:ePackage.EClassifiers�
			�IF eClassifier instanceof EClass�
				�(eClassifier as EClass).generatePropertiesForClassImplementation�
			�ELSE�
				�(eClassifier as EDataType).generatePropertiesForDataTypeImplementation�
			�ENDIF�
		�ENDFOR�
	}
} // UnityCMF.�ePackage.name�
