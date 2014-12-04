using UnityCMF.CCore;
using UnityCMF.ECore;

namespace �ePackage.fullPackageName� {
	 
	public interface �eClass.classifierName� : �eClass.superInterfaceDeclaration� {
		�FOR eFeature:eClass.EStructuralFeatures�
			�IF !eFeature.filter�
				�eFeature.generateFeatureInterface�
			�ENDIF�
		�ENDFOR�
	}
	
	public class �eClass.classifierName�Impl : CObjectImpl, �eClass.classifierName� {
		public �eClass.name.toFirstUpper�Impl(UnityCMF.ECore.EClass eClass) : base(eClass) {
		}
		
		�FOR eFeature:eClass.EAllStructuralFeatures�
			�IF !eFeature.filter�
				�eFeature.generateFeatureImplementation�
			�ENDIF�
		�ENDFOR�
	}
} // UnityCMF.�eClass.EPackage.name�
