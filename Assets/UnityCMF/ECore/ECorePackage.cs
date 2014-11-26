
namespace UnityCMF.ECore {			 
	public interface ECorePackage {
		public static ECorePackage cINSTANCE = new ECorePackageImpl();
		
		UnityCMF.ECore.EClass EAttribute { get; }
		EStructuralFeature EAttribute_iD { get; }
		UnityCMF.ECore.EClass EAnnotation { get; }
		EStructuralFeature EAnnotation_source { get; }
		EStructuralFeature EAnnotation_details { get; }
		EStructuralFeature EAnnotation_eModelElement { get; }
		EStructuralFeature EAnnotation_contents { get; }
		EStructuralFeature EAnnotation_references { get; }
		UnityCMF.ECore.EClass EClass { get; }
		EStructuralFeature EClass_abstract { get; }
		EStructuralFeature EClass_interface { get; }
		EStructuralFeature EClass_eSuperTypes { get; }
		EStructuralFeature EClass_eOperations { get; }
		EStructuralFeature EClass_eStructuralFeatures { get; }
		EStructuralFeature EClass_eGenericSuperTypes { get; }
		UnityCMF.ECore.EClass EClassifier { get; }
		EStructuralFeature EClassifier_instanceClassName { get; }
		EStructuralFeature EClassifier_instanceTypeName { get; }
		EStructuralFeature EClassifier_ePackage { get; }
		EStructuralFeature EClassifier_eTypeParameters { get; }
		UnityCMF.ECore.EClass EDataType { get; }
		EStructuralFeature EDataType_serializable { get; }
		UnityCMF.ECore.EClass EEnum { get; }
		EStructuralFeature EEnum_eLiterals { get; }
		UnityCMF.ECore.EClass EEnumLiteral { get; }
		EStructuralFeature EEnumLiteral_value { get; }
		EStructuralFeature EEnumLiteral_instance { get; }
		EStructuralFeature EEnumLiteral_literal { get; }
		EStructuralFeature EEnumLiteral_eEnum { get; }
		UnityCMF.ECore.EClass EFactory { get; }
		EStructuralFeature EFactory_ePackage { get; }
		UnityCMF.ECore.EClass EModelElement { get; }
		EStructuralFeature EModelElement_eAnnotations { get; }
		UnityCMF.ECore.EClass ENamedElement { get; }
		EStructuralFeature ENamedElement_name { get; }
		UnityCMF.ECore.EClass EObject { get; }
		UnityCMF.ECore.EClass EOperation { get; }
		EStructuralFeature EOperation_eContainingClass { get; }
		EStructuralFeature EOperation_eTypeParameters { get; }
		EStructuralFeature EOperation_eParameters { get; }
		EStructuralFeature EOperation_eExceptions { get; }
		EStructuralFeature EOperation_eGenericExceptions { get; }
		UnityCMF.ECore.EClass EPackage { get; }
		EStructuralFeature EPackage_nsURI { get; }
		EStructuralFeature EPackage_nsPrefix { get; }
		EStructuralFeature EPackage_eFactoryInstance { get; }
		EStructuralFeature EPackage_eClassifiers { get; }
		EStructuralFeature EPackage_eSubpackages { get; }
		EStructuralFeature EPackage_eSuperPackage { get; }
		UnityCMF.ECore.EClass EParameter { get; }
		EStructuralFeature EParameter_eOperation { get; }
		UnityCMF.ECore.EClass EReference { get; }
		EStructuralFeature EReference_containment { get; }
		EStructuralFeature EReference_resolveProxies { get; }
		EStructuralFeature EReference_eOpposite { get; }
		EStructuralFeature EReference_eKeys { get; }
		UnityCMF.ECore.EClass EStructuralFeature { get; }
		EStructuralFeature EStructuralFeature_changeable { get; }
		EStructuralFeature EStructuralFeature_volatile { get; }
		EStructuralFeature EStructuralFeature_transient { get; }
		EStructuralFeature EStructuralFeature_defaultValueLiteral { get; }
		EStructuralFeature EStructuralFeature_unsettable { get; }
		EStructuralFeature EStructuralFeature_derived { get; }
		EStructuralFeature EStructuralFeature_eContainingClass { get; }
		UnityCMF.ECore.EClass ETypedElement { get; }
		EStructuralFeature ETypedElement_ordered { get; }
		EStructuralFeature ETypedElement_unique { get; }
		EStructuralFeature ETypedElement_lowerBound { get; }
		EStructuralFeature ETypedElement_upperBound { get; }
		EStructuralFeature ETypedElement_eType { get; }
		EStructuralFeature ETypedElement_eGenericType { get; }
		UnityCMF.ECore.EClass EStringToStringMapEntry { get; }
		EStructuralFeature EStringToStringMapEntry_key { get; }
		EStructuralFeature EStringToStringMapEntry_value { get; }
		UnityCMF.ECore.EClass EGenericType { get; }
		EStructuralFeature EGenericType_eUpperBound { get; }
		EStructuralFeature EGenericType_eTypeArguments { get; }
		EStructuralFeature EGenericType_eLowerBound { get; }
		EStructuralFeature EGenericType_eTypeParameter { get; }
		EStructuralFeature EGenericType_eClassifier { get; }
		UnityCMF.ECore.EClass ETypeParameter { get; }
		EStructuralFeature ETypeParameter_eBounds { get; }
	}
	
	public class ECorePackageImpl : ECorePackage {
		public ECorePackageImpl() {
			EAttribute = UnityCMF.ECore.ECoreFactory.cINSTANCE.CreateEClass();
			EAttribute.Name = "EAttribute";
			EAttribute_iD = UnityCMF.ECore.ECoreFactory.cINSTANCE.CreateEStructuralFeature();
			EAttribute_iD.Name = "iD";
			EAttribute_iD.Many = false;
			EAttribute_iD.EType = UnityCMF.Ecore.EcorePackage.cINSTANCE.EBoolean;
			EAttribute.EStructuralFeatures.Add(EAttribute_iD);
					
			EAnnotation = UnityCMF.ECore.ECoreFactory.cINSTANCE.CreateEClass();
			EAnnotation.Name = "EAnnotation";
			EAnnotation_source = UnityCMF.ECore.ECoreFactory.cINSTANCE.CreateEStructuralFeature();
			EAnnotation_source.Name = "source";
			EAnnotation_source.Many = false;
			EAnnotation_source.EType = UnityCMF.Ecore.EcorePackage.cINSTANCE.EString;
			EAnnotation.EStructuralFeatures.Add(EAnnotation_source);
			EAnnotation_details = UnityCMF.ECore.ECoreFactory.cINSTANCE.CreateEStructuralFeature();
			EAnnotation_details.Name = "details";
			EAnnotation_details.Many = true;
			EAnnotation_details.EType = UnityCMF.Ecore.EcorePackage.cINSTANCE.EStringToStringMapEntry;
			EAnnotation.EStructuralFeatures.Add(EAnnotation_details);
			EAnnotation_eModelElement = UnityCMF.ECore.ECoreFactory.cINSTANCE.CreateEStructuralFeature();
			EAnnotation_eModelElement.Name = "eModelElement";
			EAnnotation_eModelElement.Many = false;
			EAnnotation_eModelElement.EType = UnityCMF.Ecore.EcorePackage.cINSTANCE.EModelElement;
			EAnnotation.EStructuralFeatures.Add(EAnnotation_eModelElement);
			EAnnotation_contents = UnityCMF.ECore.ECoreFactory.cINSTANCE.CreateEStructuralFeature();
			EAnnotation_contents.Name = "contents";
			EAnnotation_contents.Many = true;
			EAnnotation_contents.EType = UnityCMF.Ecore.EcorePackage.cINSTANCE.EObject;
			EAnnotation.EStructuralFeatures.Add(EAnnotation_contents);
			EAnnotation_references = UnityCMF.ECore.ECoreFactory.cINSTANCE.CreateEStructuralFeature();
			EAnnotation_references.Name = "references";
			EAnnotation_references.Many = true;
			EAnnotation_references.EType = UnityCMF.Ecore.EcorePackage.cINSTANCE.EObject;
			EAnnotation.EStructuralFeatures.Add(EAnnotation_references);
					
			EClass = UnityCMF.ECore.ECoreFactory.cINSTANCE.CreateEClass();
			EClass.Name = "EClass";
			EClass_abstract = UnityCMF.ECore.ECoreFactory.cINSTANCE.CreateEStructuralFeature();
			EClass_abstract.Name = "abstract";
			EClass_abstract.Many = false;
			EClass_abstract.EType = UnityCMF.Ecore.EcorePackage.cINSTANCE.EBoolean;
			EClass.EStructuralFeatures.Add(EClass_abstract);
			EClass_interface = UnityCMF.ECore.ECoreFactory.cINSTANCE.CreateEStructuralFeature();
			EClass_interface.Name = "interface";
			EClass_interface.Many = false;
			EClass_interface.EType = UnityCMF.Ecore.EcorePackage.cINSTANCE.EBoolean;
			EClass.EStructuralFeatures.Add(EClass_interface);
			EClass_eSuperTypes = UnityCMF.ECore.ECoreFactory.cINSTANCE.CreateEStructuralFeature();
			EClass_eSuperTypes.Name = "eSuperTypes";
			EClass_eSuperTypes.Many = true;
			EClass_eSuperTypes.EType = UnityCMF.Ecore.EcorePackage.cINSTANCE.EClass;
			EClass.EStructuralFeatures.Add(EClass_eSuperTypes);
			EClass_eOperations = UnityCMF.ECore.ECoreFactory.cINSTANCE.CreateEStructuralFeature();
			EClass_eOperations.Name = "eOperations";
			EClass_eOperations.Many = true;
			EClass_eOperations.EType = UnityCMF.Ecore.EcorePackage.cINSTANCE.EOperation;
			EClass.EStructuralFeatures.Add(EClass_eOperations);
			EClass_eStructuralFeatures = UnityCMF.ECore.ECoreFactory.cINSTANCE.CreateEStructuralFeature();
			EClass_eStructuralFeatures.Name = "eStructuralFeatures";
			EClass_eStructuralFeatures.Many = true;
			EClass_eStructuralFeatures.EType = UnityCMF.Ecore.EcorePackage.cINSTANCE.EStructuralFeature;
			EClass.EStructuralFeatures.Add(EClass_eStructuralFeatures);
			EClass_eGenericSuperTypes = UnityCMF.ECore.ECoreFactory.cINSTANCE.CreateEStructuralFeature();
			EClass_eGenericSuperTypes.Name = "eGenericSuperTypes";
			EClass_eGenericSuperTypes.Many = true;
			EClass_eGenericSuperTypes.EType = UnityCMF.Ecore.EcorePackage.cINSTANCE.EGenericType;
			EClass.EStructuralFeatures.Add(EClass_eGenericSuperTypes);
					
			EClassifier = UnityCMF.ECore.ECoreFactory.cINSTANCE.CreateEClass();
			EClassifier.Name = "EClassifier";
			EClassifier_instanceClassName = UnityCMF.ECore.ECoreFactory.cINSTANCE.CreateEStructuralFeature();
			EClassifier_instanceClassName.Name = "instanceClassName";
			EClassifier_instanceClassName.Many = false;
			EClassifier_instanceClassName.EType = UnityCMF.Ecore.EcorePackage.cINSTANCE.EString;
			EClassifier.EStructuralFeatures.Add(EClassifier_instanceClassName);
			EClassifier_instanceTypeName = UnityCMF.ECore.ECoreFactory.cINSTANCE.CreateEStructuralFeature();
			EClassifier_instanceTypeName.Name = "instanceTypeName";
			EClassifier_instanceTypeName.Many = false;
			EClassifier_instanceTypeName.EType = UnityCMF.Ecore.EcorePackage.cINSTANCE.EString;
			EClassifier.EStructuralFeatures.Add(EClassifier_instanceTypeName);
			EClassifier_ePackage = UnityCMF.ECore.ECoreFactory.cINSTANCE.CreateEStructuralFeature();
			EClassifier_ePackage.Name = "ePackage";
			EClassifier_ePackage.Many = false;
			EClassifier_ePackage.EType = UnityCMF.Ecore.EcorePackage.cINSTANCE.EPackage;
			EClassifier.EStructuralFeatures.Add(EClassifier_ePackage);
			EClassifier_eTypeParameters = UnityCMF.ECore.ECoreFactory.cINSTANCE.CreateEStructuralFeature();
			EClassifier_eTypeParameters.Name = "eTypeParameters";
			EClassifier_eTypeParameters.Many = true;
			EClassifier_eTypeParameters.EType = UnityCMF.Ecore.EcorePackage.cINSTANCE.ETypeParameter;
			EClassifier.EStructuralFeatures.Add(EClassifier_eTypeParameters);
					
			EDataType = UnityCMF.ECore.ECoreFactory.cINSTANCE.CreateEClass();
			EDataType.Name = "EDataType";
			EDataType_serializable = UnityCMF.ECore.ECoreFactory.cINSTANCE.CreateEStructuralFeature();
			EDataType_serializable.Name = "serializable";
			EDataType_serializable.Many = false;
			EDataType_serializable.EType = UnityCMF.Ecore.EcorePackage.cINSTANCE.EBoolean;
			EDataType.EStructuralFeatures.Add(EDataType_serializable);
					
			EEnum = UnityCMF.ECore.ECoreFactory.cINSTANCE.CreateEClass();
			EEnum.Name = "EEnum";
			EEnum_eLiterals = UnityCMF.ECore.ECoreFactory.cINSTANCE.CreateEStructuralFeature();
			EEnum_eLiterals.Name = "eLiterals";
			EEnum_eLiterals.Many = true;
			EEnum_eLiterals.EType = UnityCMF.Ecore.EcorePackage.cINSTANCE.EEnumLiteral;
			EEnum.EStructuralFeatures.Add(EEnum_eLiterals);
					
			EEnumLiteral = UnityCMF.ECore.ECoreFactory.cINSTANCE.CreateEClass();
			EEnumLiteral.Name = "EEnumLiteral";
			EEnumLiteral_value = UnityCMF.ECore.ECoreFactory.cINSTANCE.CreateEStructuralFeature();
			EEnumLiteral_value.Name = "value";
			EEnumLiteral_value.Many = false;
			EEnumLiteral_value.EType = UnityCMF.Ecore.EcorePackage.cINSTANCE.EInt;
			EEnumLiteral.EStructuralFeatures.Add(EEnumLiteral_value);
			EEnumLiteral_instance = UnityCMF.ECore.ECoreFactory.cINSTANCE.CreateEStructuralFeature();
			EEnumLiteral_instance.Name = "instance";
			EEnumLiteral_instance.Many = false;
			EEnumLiteral_instance.EType = UnityCMF.Ecore.EcorePackage.cINSTANCE.EEnumerator;
			EEnumLiteral.EStructuralFeatures.Add(EEnumLiteral_instance);
			EEnumLiteral_literal = UnityCMF.ECore.ECoreFactory.cINSTANCE.CreateEStructuralFeature();
			EEnumLiteral_literal.Name = "literal";
			EEnumLiteral_literal.Many = false;
			EEnumLiteral_literal.EType = UnityCMF.Ecore.EcorePackage.cINSTANCE.EString;
			EEnumLiteral.EStructuralFeatures.Add(EEnumLiteral_literal);
			EEnumLiteral_eEnum = UnityCMF.ECore.ECoreFactory.cINSTANCE.CreateEStructuralFeature();
			EEnumLiteral_eEnum.Name = "eEnum";
			EEnumLiteral_eEnum.Many = false;
			EEnumLiteral_eEnum.EType = UnityCMF.Ecore.EcorePackage.cINSTANCE.EEnum;
			EEnumLiteral.EStructuralFeatures.Add(EEnumLiteral_eEnum);
					
			EFactory = UnityCMF.ECore.ECoreFactory.cINSTANCE.CreateEClass();
			EFactory.Name = "EFactory";
			EFactory_ePackage = UnityCMF.ECore.ECoreFactory.cINSTANCE.CreateEStructuralFeature();
			EFactory_ePackage.Name = "ePackage";
			EFactory_ePackage.Many = false;
			EFactory_ePackage.EType = UnityCMF.Ecore.EcorePackage.cINSTANCE.EPackage;
			EFactory.EStructuralFeatures.Add(EFactory_ePackage);
					
			EModelElement = UnityCMF.ECore.ECoreFactory.cINSTANCE.CreateEClass();
			EModelElement.Name = "EModelElement";
			EModelElement_eAnnotations = UnityCMF.ECore.ECoreFactory.cINSTANCE.CreateEStructuralFeature();
			EModelElement_eAnnotations.Name = "eAnnotations";
			EModelElement_eAnnotations.Many = true;
			EModelElement_eAnnotations.EType = UnityCMF.Ecore.EcorePackage.cINSTANCE.EAnnotation;
			EModelElement.EStructuralFeatures.Add(EModelElement_eAnnotations);
					
			ENamedElement = UnityCMF.ECore.ECoreFactory.cINSTANCE.CreateEClass();
			ENamedElement.Name = "ENamedElement";
			ENamedElement_name = UnityCMF.ECore.ECoreFactory.cINSTANCE.CreateEStructuralFeature();
			ENamedElement_name.Name = "name";
			ENamedElement_name.Many = false;
			ENamedElement_name.EType = UnityCMF.Ecore.EcorePackage.cINSTANCE.EString;
			ENamedElement.EStructuralFeatures.Add(ENamedElement_name);
					
			EObject = UnityCMF.ECore.ECoreFactory.cINSTANCE.CreateEClass();
			EObject.Name = "EObject";
					
			EOperation = UnityCMF.ECore.ECoreFactory.cINSTANCE.CreateEClass();
			EOperation.Name = "EOperation";
			EOperation_eContainingClass = UnityCMF.ECore.ECoreFactory.cINSTANCE.CreateEStructuralFeature();
			EOperation_eContainingClass.Name = "eContainingClass";
			EOperation_eContainingClass.Many = false;
			EOperation_eContainingClass.EType = UnityCMF.Ecore.EcorePackage.cINSTANCE.EClass;
			EOperation.EStructuralFeatures.Add(EOperation_eContainingClass);
			EOperation_eTypeParameters = UnityCMF.ECore.ECoreFactory.cINSTANCE.CreateEStructuralFeature();
			EOperation_eTypeParameters.Name = "eTypeParameters";
			EOperation_eTypeParameters.Many = true;
			EOperation_eTypeParameters.EType = UnityCMF.Ecore.EcorePackage.cINSTANCE.ETypeParameter;
			EOperation.EStructuralFeatures.Add(EOperation_eTypeParameters);
			EOperation_eParameters = UnityCMF.ECore.ECoreFactory.cINSTANCE.CreateEStructuralFeature();
			EOperation_eParameters.Name = "eParameters";
			EOperation_eParameters.Many = true;
			EOperation_eParameters.EType = UnityCMF.Ecore.EcorePackage.cINSTANCE.EParameter;
			EOperation.EStructuralFeatures.Add(EOperation_eParameters);
			EOperation_eExceptions = UnityCMF.ECore.ECoreFactory.cINSTANCE.CreateEStructuralFeature();
			EOperation_eExceptions.Name = "eExceptions";
			EOperation_eExceptions.Many = true;
			EOperation_eExceptions.EType = UnityCMF.Ecore.EcorePackage.cINSTANCE.EClassifier;
			EOperation.EStructuralFeatures.Add(EOperation_eExceptions);
			EOperation_eGenericExceptions = UnityCMF.ECore.ECoreFactory.cINSTANCE.CreateEStructuralFeature();
			EOperation_eGenericExceptions.Name = "eGenericExceptions";
			EOperation_eGenericExceptions.Many = true;
			EOperation_eGenericExceptions.EType = UnityCMF.Ecore.EcorePackage.cINSTANCE.EGenericType;
			EOperation.EStructuralFeatures.Add(EOperation_eGenericExceptions);
					
			EPackage = UnityCMF.ECore.ECoreFactory.cINSTANCE.CreateEClass();
			EPackage.Name = "EPackage";
			EPackage_nsURI = UnityCMF.ECore.ECoreFactory.cINSTANCE.CreateEStructuralFeature();
			EPackage_nsURI.Name = "nsURI";
			EPackage_nsURI.Many = false;
			EPackage_nsURI.EType = UnityCMF.Ecore.EcorePackage.cINSTANCE.EString;
			EPackage.EStructuralFeatures.Add(EPackage_nsURI);
			EPackage_nsPrefix = UnityCMF.ECore.ECoreFactory.cINSTANCE.CreateEStructuralFeature();
			EPackage_nsPrefix.Name = "nsPrefix";
			EPackage_nsPrefix.Many = false;
			EPackage_nsPrefix.EType = UnityCMF.Ecore.EcorePackage.cINSTANCE.EString;
			EPackage.EStructuralFeatures.Add(EPackage_nsPrefix);
			EPackage_eFactoryInstance = UnityCMF.ECore.ECoreFactory.cINSTANCE.CreateEStructuralFeature();
			EPackage_eFactoryInstance.Name = "eFactoryInstance";
			EPackage_eFactoryInstance.Many = false;
			EPackage_eFactoryInstance.EType = UnityCMF.Ecore.EcorePackage.cINSTANCE.EFactory;
			EPackage.EStructuralFeatures.Add(EPackage_eFactoryInstance);
			EPackage_eClassifiers = UnityCMF.ECore.ECoreFactory.cINSTANCE.CreateEStructuralFeature();
			EPackage_eClassifiers.Name = "eClassifiers";
			EPackage_eClassifiers.Many = true;
			EPackage_eClassifiers.EType = UnityCMF.Ecore.EcorePackage.cINSTANCE.EClassifier;
			EPackage.EStructuralFeatures.Add(EPackage_eClassifiers);
			EPackage_eSubpackages = UnityCMF.ECore.ECoreFactory.cINSTANCE.CreateEStructuralFeature();
			EPackage_eSubpackages.Name = "eSubpackages";
			EPackage_eSubpackages.Many = true;
			EPackage_eSubpackages.EType = UnityCMF.Ecore.EcorePackage.cINSTANCE.EPackage;
			EPackage.EStructuralFeatures.Add(EPackage_eSubpackages);
			EPackage_eSuperPackage = UnityCMF.ECore.ECoreFactory.cINSTANCE.CreateEStructuralFeature();
			EPackage_eSuperPackage.Name = "eSuperPackage";
			EPackage_eSuperPackage.Many = false;
			EPackage_eSuperPackage.EType = UnityCMF.Ecore.EcorePackage.cINSTANCE.EPackage;
			EPackage.EStructuralFeatures.Add(EPackage_eSuperPackage);
					
			EParameter = UnityCMF.ECore.ECoreFactory.cINSTANCE.CreateEClass();
			EParameter.Name = "EParameter";
			EParameter_eOperation = UnityCMF.ECore.ECoreFactory.cINSTANCE.CreateEStructuralFeature();
			EParameter_eOperation.Name = "eOperation";
			EParameter_eOperation.Many = false;
			EParameter_eOperation.EType = UnityCMF.Ecore.EcorePackage.cINSTANCE.EOperation;
			EParameter.EStructuralFeatures.Add(EParameter_eOperation);
					
			EReference = UnityCMF.ECore.ECoreFactory.cINSTANCE.CreateEClass();
			EReference.Name = "EReference";
			EReference_containment = UnityCMF.ECore.ECoreFactory.cINSTANCE.CreateEStructuralFeature();
			EReference_containment.Name = "containment";
			EReference_containment.Many = false;
			EReference_containment.EType = UnityCMF.Ecore.EcorePackage.cINSTANCE.EBoolean;
			EReference.EStructuralFeatures.Add(EReference_containment);
			EReference_resolveProxies = UnityCMF.ECore.ECoreFactory.cINSTANCE.CreateEStructuralFeature();
			EReference_resolveProxies.Name = "resolveProxies";
			EReference_resolveProxies.Many = false;
			EReference_resolveProxies.EType = UnityCMF.Ecore.EcorePackage.cINSTANCE.EBoolean;
			EReference.EStructuralFeatures.Add(EReference_resolveProxies);
			EReference_eOpposite = UnityCMF.ECore.ECoreFactory.cINSTANCE.CreateEStructuralFeature();
			EReference_eOpposite.Name = "eOpposite";
			EReference_eOpposite.Many = false;
			EReference_eOpposite.EType = UnityCMF.Ecore.EcorePackage.cINSTANCE.EReference;
			EReference.EStructuralFeatures.Add(EReference_eOpposite);
			EReference_eKeys = UnityCMF.ECore.ECoreFactory.cINSTANCE.CreateEStructuralFeature();
			EReference_eKeys.Name = "eKeys";
			EReference_eKeys.Many = true;
			EReference_eKeys.EType = UnityCMF.Ecore.EcorePackage.cINSTANCE.EAttribute;
			EReference.EStructuralFeatures.Add(EReference_eKeys);
					
			EStructuralFeature = UnityCMF.ECore.ECoreFactory.cINSTANCE.CreateEClass();
			EStructuralFeature.Name = "EStructuralFeature";
			EStructuralFeature_changeable = UnityCMF.ECore.ECoreFactory.cINSTANCE.CreateEStructuralFeature();
			EStructuralFeature_changeable.Name = "changeable";
			EStructuralFeature_changeable.Many = false;
			EStructuralFeature_changeable.EType = UnityCMF.Ecore.EcorePackage.cINSTANCE.EBoolean;
			EStructuralFeature.EStructuralFeatures.Add(EStructuralFeature_changeable);
			EStructuralFeature_volatile = UnityCMF.ECore.ECoreFactory.cINSTANCE.CreateEStructuralFeature();
			EStructuralFeature_volatile.Name = "volatile";
			EStructuralFeature_volatile.Many = false;
			EStructuralFeature_volatile.EType = UnityCMF.Ecore.EcorePackage.cINSTANCE.EBoolean;
			EStructuralFeature.EStructuralFeatures.Add(EStructuralFeature_volatile);
			EStructuralFeature_transient = UnityCMF.ECore.ECoreFactory.cINSTANCE.CreateEStructuralFeature();
			EStructuralFeature_transient.Name = "transient";
			EStructuralFeature_transient.Many = false;
			EStructuralFeature_transient.EType = UnityCMF.Ecore.EcorePackage.cINSTANCE.EBoolean;
			EStructuralFeature.EStructuralFeatures.Add(EStructuralFeature_transient);
			EStructuralFeature_defaultValueLiteral = UnityCMF.ECore.ECoreFactory.cINSTANCE.CreateEStructuralFeature();
			EStructuralFeature_defaultValueLiteral.Name = "defaultValueLiteral";
			EStructuralFeature_defaultValueLiteral.Many = false;
			EStructuralFeature_defaultValueLiteral.EType = UnityCMF.Ecore.EcorePackage.cINSTANCE.EString;
			EStructuralFeature.EStructuralFeatures.Add(EStructuralFeature_defaultValueLiteral);
			EStructuralFeature_unsettable = UnityCMF.ECore.ECoreFactory.cINSTANCE.CreateEStructuralFeature();
			EStructuralFeature_unsettable.Name = "unsettable";
			EStructuralFeature_unsettable.Many = false;
			EStructuralFeature_unsettable.EType = UnityCMF.Ecore.EcorePackage.cINSTANCE.EBoolean;
			EStructuralFeature.EStructuralFeatures.Add(EStructuralFeature_unsettable);
			EStructuralFeature_derived = UnityCMF.ECore.ECoreFactory.cINSTANCE.CreateEStructuralFeature();
			EStructuralFeature_derived.Name = "derived";
			EStructuralFeature_derived.Many = false;
			EStructuralFeature_derived.EType = UnityCMF.Ecore.EcorePackage.cINSTANCE.EBoolean;
			EStructuralFeature.EStructuralFeatures.Add(EStructuralFeature_derived);
			EStructuralFeature_eContainingClass = UnityCMF.ECore.ECoreFactory.cINSTANCE.CreateEStructuralFeature();
			EStructuralFeature_eContainingClass.Name = "eContainingClass";
			EStructuralFeature_eContainingClass.Many = false;
			EStructuralFeature_eContainingClass.EType = UnityCMF.Ecore.EcorePackage.cINSTANCE.EClass;
			EStructuralFeature.EStructuralFeatures.Add(EStructuralFeature_eContainingClass);
					
			ETypedElement = UnityCMF.ECore.ECoreFactory.cINSTANCE.CreateEClass();
			ETypedElement.Name = "ETypedElement";
			ETypedElement_ordered = UnityCMF.ECore.ECoreFactory.cINSTANCE.CreateEStructuralFeature();
			ETypedElement_ordered.Name = "ordered";
			ETypedElement_ordered.Many = false;
			ETypedElement_ordered.EType = UnityCMF.Ecore.EcorePackage.cINSTANCE.EBoolean;
			ETypedElement.EStructuralFeatures.Add(ETypedElement_ordered);
			ETypedElement_unique = UnityCMF.ECore.ECoreFactory.cINSTANCE.CreateEStructuralFeature();
			ETypedElement_unique.Name = "unique";
			ETypedElement_unique.Many = false;
			ETypedElement_unique.EType = UnityCMF.Ecore.EcorePackage.cINSTANCE.EBoolean;
			ETypedElement.EStructuralFeatures.Add(ETypedElement_unique);
			ETypedElement_lowerBound = UnityCMF.ECore.ECoreFactory.cINSTANCE.CreateEStructuralFeature();
			ETypedElement_lowerBound.Name = "lowerBound";
			ETypedElement_lowerBound.Many = false;
			ETypedElement_lowerBound.EType = UnityCMF.Ecore.EcorePackage.cINSTANCE.EInt;
			ETypedElement.EStructuralFeatures.Add(ETypedElement_lowerBound);
			ETypedElement_upperBound = UnityCMF.ECore.ECoreFactory.cINSTANCE.CreateEStructuralFeature();
			ETypedElement_upperBound.Name = "upperBound";
			ETypedElement_upperBound.Many = false;
			ETypedElement_upperBound.EType = UnityCMF.Ecore.EcorePackage.cINSTANCE.EInt;
			ETypedElement.EStructuralFeatures.Add(ETypedElement_upperBound);
			ETypedElement_eType = UnityCMF.ECore.ECoreFactory.cINSTANCE.CreateEStructuralFeature();
			ETypedElement_eType.Name = "eType";
			ETypedElement_eType.Many = false;
			ETypedElement_eType.EType = UnityCMF.Ecore.EcorePackage.cINSTANCE.EClassifier;
			ETypedElement.EStructuralFeatures.Add(ETypedElement_eType);
			ETypedElement_eGenericType = UnityCMF.ECore.ECoreFactory.cINSTANCE.CreateEStructuralFeature();
			ETypedElement_eGenericType.Name = "eGenericType";
			ETypedElement_eGenericType.Many = false;
			ETypedElement_eGenericType.EType = UnityCMF.Ecore.EcorePackage.cINSTANCE.EGenericType;
			ETypedElement.EStructuralFeatures.Add(ETypedElement_eGenericType);
					
			EStringToStringMapEntry = UnityCMF.ECore.ECoreFactory.cINSTANCE.CreateEClass();
			EStringToStringMapEntry.Name = "EStringToStringMapEntry";
			EStringToStringMapEntry_key = UnityCMF.ECore.ECoreFactory.cINSTANCE.CreateEStructuralFeature();
			EStringToStringMapEntry_key.Name = "key";
			EStringToStringMapEntry_key.Many = false;
			EStringToStringMapEntry_key.EType = UnityCMF.Ecore.EcorePackage.cINSTANCE.EString;
			EStringToStringMapEntry.EStructuralFeatures.Add(EStringToStringMapEntry_key);
			EStringToStringMapEntry_value = UnityCMF.ECore.ECoreFactory.cINSTANCE.CreateEStructuralFeature();
			EStringToStringMapEntry_value.Name = "value";
			EStringToStringMapEntry_value.Many = false;
			EStringToStringMapEntry_value.EType = UnityCMF.Ecore.EcorePackage.cINSTANCE.EString;
			EStringToStringMapEntry.EStructuralFeatures.Add(EStringToStringMapEntry_value);
					
			EGenericType = UnityCMF.ECore.ECoreFactory.cINSTANCE.CreateEClass();
			EGenericType.Name = "EGenericType";
			EGenericType_eUpperBound = UnityCMF.ECore.ECoreFactory.cINSTANCE.CreateEStructuralFeature();
			EGenericType_eUpperBound.Name = "eUpperBound";
			EGenericType_eUpperBound.Many = false;
			EGenericType_eUpperBound.EType = UnityCMF.Ecore.EcorePackage.cINSTANCE.EGenericType;
			EGenericType.EStructuralFeatures.Add(EGenericType_eUpperBound);
			EGenericType_eTypeArguments = UnityCMF.ECore.ECoreFactory.cINSTANCE.CreateEStructuralFeature();
			EGenericType_eTypeArguments.Name = "eTypeArguments";
			EGenericType_eTypeArguments.Many = true;
			EGenericType_eTypeArguments.EType = UnityCMF.Ecore.EcorePackage.cINSTANCE.EGenericType;
			EGenericType.EStructuralFeatures.Add(EGenericType_eTypeArguments);
			EGenericType_eLowerBound = UnityCMF.ECore.ECoreFactory.cINSTANCE.CreateEStructuralFeature();
			EGenericType_eLowerBound.Name = "eLowerBound";
			EGenericType_eLowerBound.Many = false;
			EGenericType_eLowerBound.EType = UnityCMF.Ecore.EcorePackage.cINSTANCE.EGenericType;
			EGenericType.EStructuralFeatures.Add(EGenericType_eLowerBound);
			EGenericType_eTypeParameter = UnityCMF.ECore.ECoreFactory.cINSTANCE.CreateEStructuralFeature();
			EGenericType_eTypeParameter.Name = "eTypeParameter";
			EGenericType_eTypeParameter.Many = false;
			EGenericType_eTypeParameter.EType = UnityCMF.Ecore.EcorePackage.cINSTANCE.ETypeParameter;
			EGenericType.EStructuralFeatures.Add(EGenericType_eTypeParameter);
			EGenericType_eClassifier = UnityCMF.ECore.ECoreFactory.cINSTANCE.CreateEStructuralFeature();
			EGenericType_eClassifier.Name = "eClassifier";
			EGenericType_eClassifier.Many = false;
			EGenericType_eClassifier.EType = UnityCMF.Ecore.EcorePackage.cINSTANCE.EClassifier;
			EGenericType.EStructuralFeatures.Add(EGenericType_eClassifier);
					
			ETypeParameter = UnityCMF.ECore.ECoreFactory.cINSTANCE.CreateEClass();
			ETypeParameter.Name = "ETypeParameter";
			ETypeParameter_eBounds = UnityCMF.ECore.ECoreFactory.cINSTANCE.CreateEStructuralFeature();
			ETypeParameter_eBounds.Name = "eBounds";
			ETypeParameter_eBounds.Many = true;
			ETypeParameter_eBounds.EType = UnityCMF.Ecore.EcorePackage.cINSTANCE.EGenericType;
			ETypeParameter.EStructuralFeatures.Add(ETypeParameter_eBounds);
					
		}
		
		public UnityCMF.ECore.EClass EAttribute { public get; private set;}
		public EStructuralFeature EAttribute_iD  { public get; private set;}
		public UnityCMF.ECore.EClass EAnnotation { public get; private set;}
		public EStructuralFeature EAnnotation_source  { public get; private set;}
		public EStructuralFeature EAnnotation_details  { public get; private set;}
		public EStructuralFeature EAnnotation_eModelElement  { public get; private set;}
		public EStructuralFeature EAnnotation_contents  { public get; private set;}
		public EStructuralFeature EAnnotation_references  { public get; private set;}
		public UnityCMF.ECore.EClass EClass { public get; private set;}
		public EStructuralFeature EClass_abstract  { public get; private set;}
		public EStructuralFeature EClass_interface  { public get; private set;}
		public EStructuralFeature EClass_eSuperTypes  { public get; private set;}
		public EStructuralFeature EClass_eOperations  { public get; private set;}
		public EStructuralFeature EClass_eStructuralFeatures  { public get; private set;}
		public EStructuralFeature EClass_eGenericSuperTypes  { public get; private set;}
		public UnityCMF.ECore.EClass EClassifier { public get; private set;}
		public EStructuralFeature EClassifier_instanceClassName  { public get; private set;}
		public EStructuralFeature EClassifier_instanceTypeName  { public get; private set;}
		public EStructuralFeature EClassifier_ePackage  { public get; private set;}
		public EStructuralFeature EClassifier_eTypeParameters  { public get; private set;}
		public UnityCMF.ECore.EClass EDataType { public get; private set;}
		public EStructuralFeature EDataType_serializable  { public get; private set;}
		public UnityCMF.ECore.EClass EEnum { public get; private set;}
		public EStructuralFeature EEnum_eLiterals  { public get; private set;}
		public UnityCMF.ECore.EClass EEnumLiteral { public get; private set;}
		public EStructuralFeature EEnumLiteral_value  { public get; private set;}
		public EStructuralFeature EEnumLiteral_instance  { public get; private set;}
		public EStructuralFeature EEnumLiteral_literal  { public get; private set;}
		public EStructuralFeature EEnumLiteral_eEnum  { public get; private set;}
		public UnityCMF.ECore.EClass EFactory { public get; private set;}
		public EStructuralFeature EFactory_ePackage  { public get; private set;}
		public UnityCMF.ECore.EClass EModelElement { public get; private set;}
		public EStructuralFeature EModelElement_eAnnotations  { public get; private set;}
		public UnityCMF.ECore.EClass ENamedElement { public get; private set;}
		public EStructuralFeature ENamedElement_name  { public get; private set;}
		public UnityCMF.ECore.EClass EObject { public get; private set;}
		public UnityCMF.ECore.EClass EOperation { public get; private set;}
		public EStructuralFeature EOperation_eContainingClass  { public get; private set;}
		public EStructuralFeature EOperation_eTypeParameters  { public get; private set;}
		public EStructuralFeature EOperation_eParameters  { public get; private set;}
		public EStructuralFeature EOperation_eExceptions  { public get; private set;}
		public EStructuralFeature EOperation_eGenericExceptions  { public get; private set;}
		public UnityCMF.ECore.EClass EPackage { public get; private set;}
		public EStructuralFeature EPackage_nsURI  { public get; private set;}
		public EStructuralFeature EPackage_nsPrefix  { public get; private set;}
		public EStructuralFeature EPackage_eFactoryInstance  { public get; private set;}
		public EStructuralFeature EPackage_eClassifiers  { public get; private set;}
		public EStructuralFeature EPackage_eSubpackages  { public get; private set;}
		public EStructuralFeature EPackage_eSuperPackage  { public get; private set;}
		public UnityCMF.ECore.EClass EParameter { public get; private set;}
		public EStructuralFeature EParameter_eOperation  { public get; private set;}
		public UnityCMF.ECore.EClass EReference { public get; private set;}
		public EStructuralFeature EReference_containment  { public get; private set;}
		public EStructuralFeature EReference_resolveProxies  { public get; private set;}
		public EStructuralFeature EReference_eOpposite  { public get; private set;}
		public EStructuralFeature EReference_eKeys  { public get; private set;}
		public UnityCMF.ECore.EClass EStructuralFeature { public get; private set;}
		public EStructuralFeature EStructuralFeature_changeable  { public get; private set;}
		public EStructuralFeature EStructuralFeature_volatile  { public get; private set;}
		public EStructuralFeature EStructuralFeature_transient  { public get; private set;}
		public EStructuralFeature EStructuralFeature_defaultValueLiteral  { public get; private set;}
		public EStructuralFeature EStructuralFeature_unsettable  { public get; private set;}
		public EStructuralFeature EStructuralFeature_derived  { public get; private set;}
		public EStructuralFeature EStructuralFeature_eContainingClass  { public get; private set;}
		public UnityCMF.ECore.EClass ETypedElement { public get; private set;}
		public EStructuralFeature ETypedElement_ordered  { public get; private set;}
		public EStructuralFeature ETypedElement_unique  { public get; private set;}
		public EStructuralFeature ETypedElement_lowerBound  { public get; private set;}
		public EStructuralFeature ETypedElement_upperBound  { public get; private set;}
		public EStructuralFeature ETypedElement_eType  { public get; private set;}
		public EStructuralFeature ETypedElement_eGenericType  { public get; private set;}
		public UnityCMF.ECore.EClass EStringToStringMapEntry { public get; private set;}
		public EStructuralFeature EStringToStringMapEntry_key  { public get; private set;}
		public EStructuralFeature EStringToStringMapEntry_value  { public get; private set;}
		public UnityCMF.ECore.EClass EGenericType { public get; private set;}
		public EStructuralFeature EGenericType_eUpperBound  { public get; private set;}
		public EStructuralFeature EGenericType_eTypeArguments  { public get; private set;}
		public EStructuralFeature EGenericType_eLowerBound  { public get; private set;}
		public EStructuralFeature EGenericType_eTypeParameter  { public get; private set;}
		public EStructuralFeature EGenericType_eClassifier  { public get; private set;}
		public UnityCMF.ECore.EClass ETypeParameter { public get; private set;}
		public EStructuralFeature ETypeParameter_eBounds  { public get; private set;}
	}
} // UnityCMF.ecore
