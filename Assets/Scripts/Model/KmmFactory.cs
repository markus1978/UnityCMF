�IF ePackage != EcorePackage.eINSTANCE�
	using UnityCMF.ECore;
�ENDIF�

namespace �ePackage.fullPackageName� {
	public interface �ePackage.factoryInterfaceName� {
		�FOR eClassifier:ePackage.EClassifiers�
			�IF eClassifier instanceof EClass�
				�(eClassifier as EClass).generatePropertiesForClassInterface�
			�ENDIF�
		�ENDFOR�
	}

	public class �ePackage.factoryImplementationName� : �ePackage.factoryInterfaceName� {
		�FOR eClassifier:ePackage.EClassifiers�
			�IF eClassifier instanceof EClass�
				�(eClassifier as EClass).generatePropertiesForClassImplementation�
			�ENDIF�
		�ENDFOR�
	}
} // UnityCMF.�ePackage.name�
