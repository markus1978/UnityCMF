
namespace UnityCMF.ECore {			 
	public interface ECoreFactory {
		public static ECoreFactoryFactory cINSTANCE = new ECoreFactoryImpl();
		
		UnityCMF.ECore.EClass CreateEAttribute();
		UnityCMF.ECore.EClass CreateEAnnotation();
		UnityCMF.ECore.EClass CreateEClass();
		UnityCMF.ECore.EClass CreateEClassifier();
		UnityCMF.ECore.EClass CreateEDataType();
		UnityCMF.ECore.EClass CreateEEnum();
		UnityCMF.ECore.EClass CreateEEnumLiteral();
		UnityCMF.ECore.EClass CreateEFactory();
		UnityCMF.ECore.EClass CreateEModelElement();
		UnityCMF.ECore.EClass CreateENamedElement();
		UnityCMF.ECore.EClass CreateEObject();
		UnityCMF.ECore.EClass CreateEOperation();
		UnityCMF.ECore.EClass CreateEPackage();
		UnityCMF.ECore.EClass CreateEParameter();
		UnityCMF.ECore.EClass CreateEReference();
		UnityCMF.ECore.EClass CreateEStructuralFeature();
		UnityCMF.ECore.EClass CreateETypedElement();
		UnityCMF.ECore.EClass CreateEStringToStringMapEntry();
		UnityCMF.ECore.EClass CreateEGenericType();
		UnityCMF.ECore.EClass CreateETypeParameter();
	}
	
	public class ECoreFactoryImpl : ECoreFactory {
		public UnityCMF.ECore.EClass CreateEAttribute() {
			UnityCMF.ECore.EClass eClass = UnityCMF.Ecore.EcorePackage.cINSTANCE.EAttribute;
			return new UnityCMF.Ecore.eAttributeImpl(eClass);
		}		
		public UnityCMF.ECore.EClass CreateEAnnotation() {
			UnityCMF.ECore.EClass eClass = UnityCMF.Ecore.EcorePackage.cINSTANCE.EAnnotation;
			return new UnityCMF.Ecore.eAnnotationImpl(eClass);
		}		
		public UnityCMF.ECore.EClass CreateEClass() {
			UnityCMF.ECore.EClass eClass = UnityCMF.Ecore.EcorePackage.cINSTANCE.EClass;
			return new UnityCMF.Ecore.eClassImpl(eClass);
		}		
		public UnityCMF.ECore.EClass CreateEClassifier() {
			UnityCMF.ECore.EClass eClass = UnityCMF.Ecore.EcorePackage.cINSTANCE.EClassifier;
			return new UnityCMF.Ecore.eClassifierImpl(eClass);
		}		
		public UnityCMF.ECore.EClass CreateEDataType() {
			UnityCMF.ECore.EClass eClass = UnityCMF.Ecore.EcorePackage.cINSTANCE.EDataType;
			return new UnityCMF.Ecore.eDataTypeImpl(eClass);
		}		
		public UnityCMF.ECore.EClass CreateEEnum() {
			UnityCMF.ECore.EClass eClass = UnityCMF.Ecore.EcorePackage.cINSTANCE.EEnum;
			return new UnityCMF.Ecore.eEnumImpl(eClass);
		}		
		public UnityCMF.ECore.EClass CreateEEnumLiteral() {
			UnityCMF.ECore.EClass eClass = UnityCMF.Ecore.EcorePackage.cINSTANCE.EEnumLiteral;
			return new UnityCMF.Ecore.eEnumLiteralImpl(eClass);
		}		
		public UnityCMF.ECore.EClass CreateEFactory() {
			UnityCMF.ECore.EClass eClass = UnityCMF.Ecore.EcorePackage.cINSTANCE.EFactory;
			return new UnityCMF.Ecore.eFactoryImpl(eClass);
		}		
		public UnityCMF.ECore.EClass CreateEModelElement() {
			UnityCMF.ECore.EClass eClass = UnityCMF.Ecore.EcorePackage.cINSTANCE.EModelElement;
			return new UnityCMF.Ecore.eModelElementImpl(eClass);
		}		
		public UnityCMF.ECore.EClass CreateENamedElement() {
			UnityCMF.ECore.EClass eClass = UnityCMF.Ecore.EcorePackage.cINSTANCE.ENamedElement;
			return new UnityCMF.Ecore.eNamedElementImpl(eClass);
		}		
		public UnityCMF.ECore.EClass CreateEObject() {
			UnityCMF.ECore.EClass eClass = UnityCMF.Ecore.EcorePackage.cINSTANCE.EObject;
			return new UnityCMF.Ecore.eObjectImpl(eClass);
		}		
		public UnityCMF.ECore.EClass CreateEOperation() {
			UnityCMF.ECore.EClass eClass = UnityCMF.Ecore.EcorePackage.cINSTANCE.EOperation;
			return new UnityCMF.Ecore.eOperationImpl(eClass);
		}		
		public UnityCMF.ECore.EClass CreateEPackage() {
			UnityCMF.ECore.EClass eClass = UnityCMF.Ecore.EcorePackage.cINSTANCE.EPackage;
			return new UnityCMF.Ecore.ePackageImpl(eClass);
		}		
		public UnityCMF.ECore.EClass CreateEParameter() {
			UnityCMF.ECore.EClass eClass = UnityCMF.Ecore.EcorePackage.cINSTANCE.EParameter;
			return new UnityCMF.Ecore.eParameterImpl(eClass);
		}		
		public UnityCMF.ECore.EClass CreateEReference() {
			UnityCMF.ECore.EClass eClass = UnityCMF.Ecore.EcorePackage.cINSTANCE.EReference;
			return new UnityCMF.Ecore.eReferenceImpl(eClass);
		}		
		public UnityCMF.ECore.EClass CreateEStructuralFeature() {
			UnityCMF.ECore.EClass eClass = UnityCMF.Ecore.EcorePackage.cINSTANCE.EStructuralFeature;
			return new UnityCMF.Ecore.eStructuralFeatureImpl(eClass);
		}		
		public UnityCMF.ECore.EClass CreateETypedElement() {
			UnityCMF.ECore.EClass eClass = UnityCMF.Ecore.EcorePackage.cINSTANCE.ETypedElement;
			return new UnityCMF.Ecore.eTypedElementImpl(eClass);
		}		
		public UnityCMF.ECore.EClass CreateEStringToStringMapEntry() {
			UnityCMF.ECore.EClass eClass = UnityCMF.Ecore.EcorePackage.cINSTANCE.EStringToStringMapEntry;
			return new UnityCMF.Ecore.eStringToStringMapEntryImpl(eClass);
		}		
		public UnityCMF.ECore.EClass CreateEGenericType() {
			UnityCMF.ECore.EClass eClass = UnityCMF.Ecore.EcorePackage.cINSTANCE.EGenericType;
			return new UnityCMF.Ecore.eGenericTypeImpl(eClass);
		}		
		public UnityCMF.ECore.EClass CreateETypeParameter() {
			UnityCMF.ECore.EClass eClass = UnityCMF.Ecore.EcorePackage.cINSTANCE.ETypeParameter;
			return new UnityCMF.Ecore.eTypeParameterImpl(eClass);
		}		
	}
} // UnityCMF.ecore
