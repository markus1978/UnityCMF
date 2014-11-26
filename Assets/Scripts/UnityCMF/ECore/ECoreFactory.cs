
namespace UnityCMF.ECore {			 
	public interface ECoreFactory {
		EAttribute CreateEAttribute();
		EAnnotation CreateEAnnotation();
		EClass CreateEClass();
		EClassifier CreateEClassifier();
		EDataType CreateEDataType();
		EEnum CreateEEnum();
		EEnumLiteral CreateEEnumLiteral();
		EFactory CreateEFactory();
		EModelElement CreateEModelElement();
		ENamedElement CreateENamedElement();
		EObject CreateEObject();
		EOperation CreateEOperation();
		EPackage CreateEPackage();
		EParameter CreateEParameter();
		EReference CreateEReference();
		EStructuralFeature CreateEStructuralFeature();
		ETypedElement CreateETypedElement();
		EStringToStringMapEntry CreateEStringToStringMapEntry();
		EGenericType CreateEGenericType();
		ETypeParameter CreateETypeParameter();
	}
	
	public class ECoreFactoryImpl : ECoreFactory {
		public EAttribute CreateEAttribute() {
			UnityCMF.ECore.EClass eClass = ECoreMeta.cINSTANCE.Package.EAttribute;
			return new EAttributeImpl(eClass);
		}		
		public EAnnotation CreateEAnnotation() {
			UnityCMF.ECore.EClass eClass = ECoreMeta.cINSTANCE.Package.EAnnotation;
			return new EAnnotationImpl(eClass);
		}		
		public EClass CreateEClass() {
			UnityCMF.ECore.EClass eClass = ECoreMeta.cINSTANCE.Package.EClass;
			return new EClassImpl(eClass);
		}		
		public EClassifier CreateEClassifier() {
			UnityCMF.ECore.EClass eClass = ECoreMeta.cINSTANCE.Package.EClassifier;
			return new EClassifierImpl(eClass);
		}		
		public EDataType CreateEDataType() {
			UnityCMF.ECore.EClass eClass = ECoreMeta.cINSTANCE.Package.EDataType;
			return new EDataTypeImpl(eClass);
		}		
		public EEnum CreateEEnum() {
			UnityCMF.ECore.EClass eClass = ECoreMeta.cINSTANCE.Package.EEnum;
			return new EEnumImpl(eClass);
		}		
		public EEnumLiteral CreateEEnumLiteral() {
			UnityCMF.ECore.EClass eClass = ECoreMeta.cINSTANCE.Package.EEnumLiteral;
			return new EEnumLiteralImpl(eClass);
		}		
		public EFactory CreateEFactory() {
			UnityCMF.ECore.EClass eClass = ECoreMeta.cINSTANCE.Package.EFactory;
			return new EFactoryImpl(eClass);
		}		
		public EModelElement CreateEModelElement() {
			UnityCMF.ECore.EClass eClass = ECoreMeta.cINSTANCE.Package.EModelElement;
			return new EModelElementImpl(eClass);
		}		
		public ENamedElement CreateENamedElement() {
			UnityCMF.ECore.EClass eClass = ECoreMeta.cINSTANCE.Package.ENamedElement;
			return new ENamedElementImpl(eClass);
		}		
		public EObject CreateEObject() {
			UnityCMF.ECore.EClass eClass = ECoreMeta.cINSTANCE.Package.EObject;
			return new EObjectImpl(eClass);
		}		
		public EOperation CreateEOperation() {
			UnityCMF.ECore.EClass eClass = ECoreMeta.cINSTANCE.Package.EOperation;
			return new EOperationImpl(eClass);
		}		
		public EPackage CreateEPackage() {
			UnityCMF.ECore.EClass eClass = ECoreMeta.cINSTANCE.Package.EPackage;
			return new EPackageImpl(eClass);
		}		
		public EParameter CreateEParameter() {
			UnityCMF.ECore.EClass eClass = ECoreMeta.cINSTANCE.Package.EParameter;
			return new EParameterImpl(eClass);
		}		
		public EReference CreateEReference() {
			UnityCMF.ECore.EClass eClass = ECoreMeta.cINSTANCE.Package.EReference;
			return new EReferenceImpl(eClass);
		}		
		public EStructuralFeature CreateEStructuralFeature() {
			UnityCMF.ECore.EClass eClass = ECoreMeta.cINSTANCE.Package.EStructuralFeature;
			return new EStructuralFeatureImpl(eClass);
		}		
		public ETypedElement CreateETypedElement() {
			UnityCMF.ECore.EClass eClass = ECoreMeta.cINSTANCE.Package.ETypedElement;
			return new ETypedElementImpl(eClass);
		}		
		public EStringToStringMapEntry CreateEStringToStringMapEntry() {
			UnityCMF.ECore.EClass eClass = ECoreMeta.cINSTANCE.Package.EStringToStringMapEntry;
			return new EStringToStringMapEntryImpl(eClass);
		}		
		public EGenericType CreateEGenericType() {
			UnityCMF.ECore.EClass eClass = ECoreMeta.cINSTANCE.Package.EGenericType;
			return new EGenericTypeImpl(eClass);
		}		
		public ETypeParameter CreateETypeParameter() {
			UnityCMF.ECore.EClass eClass = ECoreMeta.cINSTANCE.Package.ETypeParameter;
			return new ETypeParameterImpl(eClass);
		}		
	}
} // UnityCMF.ecore
