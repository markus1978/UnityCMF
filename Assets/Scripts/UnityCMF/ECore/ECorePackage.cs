
namespace UnityCMF.ECore {			 
	public sealed class ECoreMeta {
		public static ECoreMeta cINSTANCE = new ECoreMeta();
		public ECorePackage Package { get; private set; }
		public ECoreFactory Factory { get; private set; }
		public ECoreMeta() {
			Package = new ECorePackageImpl();
			Factory = new ECoreFactoryImpl();
		}
	}
	
	public interface ECorePackage {
		EClass EAttribute { get; }
		EStructuralFeature EAttribute_iD { get; }
		EClass EAnnotation { get; }
		EStructuralFeature EAnnotation_source { get; }
		EStructuralFeature EAnnotation_details { get; }
		EStructuralFeature EAnnotation_eModelElement { get; }
		EStructuralFeature EAnnotation_contents { get; }
		EStructuralFeature EAnnotation_references { get; }
		EClass EClass { get; }
		EStructuralFeature EClass_abstract { get; }
		EStructuralFeature EClass_interface { get; }
		EStructuralFeature EClass_eSuperTypes { get; }
		EStructuralFeature EClass_eOperations { get; }
		EStructuralFeature EClass_eStructuralFeatures { get; }
		EStructuralFeature EClass_eGenericSuperTypes { get; }
		EClass EClassifier { get; }
		EStructuralFeature EClassifier_instanceClassName { get; }
		EStructuralFeature EClassifier_instanceTypeName { get; }
		EStructuralFeature EClassifier_ePackage { get; }
		EStructuralFeature EClassifier_eTypeParameters { get; }
		EClass EDataType { get; }
		EStructuralFeature EDataType_serializable { get; }
		EClass EEnum { get; }
		EStructuralFeature EEnum_eLiterals { get; }
		EClass EEnumLiteral { get; }
		EStructuralFeature EEnumLiteral_value { get; }
		EStructuralFeature EEnumLiteral_literal { get; }
		EStructuralFeature EEnumLiteral_eEnum { get; }
		EClass EFactory { get; }
		EStructuralFeature EFactory_ePackage { get; }
		EClass EModelElement { get; }
		EStructuralFeature EModelElement_eAnnotations { get; }
		EClass ENamedElement { get; }
		EStructuralFeature ENamedElement_name { get; }
		EClass EObject { get; }
		EClass EOperation { get; }
		EStructuralFeature EOperation_eContainingClass { get; }
		EStructuralFeature EOperation_eTypeParameters { get; }
		EStructuralFeature EOperation_eParameters { get; }
		EStructuralFeature EOperation_eExceptions { get; }
		EStructuralFeature EOperation_eGenericExceptions { get; }
		EClass EPackage { get; }
		EStructuralFeature EPackage_nsURI { get; }
		EStructuralFeature EPackage_nsPrefix { get; }
		EStructuralFeature EPackage_eFactoryInstance { get; }
		EStructuralFeature EPackage_eClassifiers { get; }
		EStructuralFeature EPackage_eSubpackages { get; }
		EStructuralFeature EPackage_eSuperPackage { get; }
		EClass EParameter { get; }
		EStructuralFeature EParameter_eOperation { get; }
		EClass EReference { get; }
		EStructuralFeature EReference_containment { get; }
		EStructuralFeature EReference_resolveProxies { get; }
		EStructuralFeature EReference_eOpposite { get; }
		EStructuralFeature EReference_eKeys { get; }
		EClass EStructuralFeature { get; }
		EStructuralFeature EStructuralFeature_changeable { get; }
		EStructuralFeature EStructuralFeature_volatile { get; }
		EStructuralFeature EStructuralFeature_transient { get; }
		EStructuralFeature EStructuralFeature_defaultValueLiteral { get; }
		EStructuralFeature EStructuralFeature_unsettable { get; }
		EStructuralFeature EStructuralFeature_derived { get; }
		EStructuralFeature EStructuralFeature_eContainingClass { get; }
		EClass ETypedElement { get; }
		EStructuralFeature ETypedElement_ordered { get; }
		EStructuralFeature ETypedElement_unique { get; }
		EStructuralFeature ETypedElement_lowerBound { get; }
		EStructuralFeature ETypedElement_upperBound { get; }
		EStructuralFeature ETypedElement_eType { get; }
		EStructuralFeature ETypedElement_eGenericType { get; }
		EClass EStringToStringMapEntry { get; }
		EStructuralFeature EStringToStringMapEntry_key { get; }
		EStructuralFeature EStringToStringMapEntry_value { get; }
		EClass EGenericType { get; }
		EStructuralFeature EGenericType_eUpperBound { get; }
		EStructuralFeature EGenericType_eTypeArguments { get; }
		EStructuralFeature EGenericType_eLowerBound { get; }
		EStructuralFeature EGenericType_eTypeParameter { get; }
		EStructuralFeature EGenericType_eClassifier { get; }
		EClass ETypeParameter { get; }
		EStructuralFeature ETypeParameter_eBounds { get; }
		EDataType EBigDecimal { get; }
		EDataType EBigInteger { get; }
		EDataType EBoolean { get; }
		EDataType EBooleanObject { get; }
		EDataType EByte { get; }
		EDataType EByteArray { get; }
		EDataType EByteObject { get; }
		EDataType EChar { get; }
		EDataType ECharacterObject { get; }
		EDataType EDate { get; }
		EDataType EDiagnosticChain { get; }
		EDataType EDouble { get; }
		EDataType EDoubleObject { get; }
		EDataType EEList { get; }
		EDataType EEnumerator { get; }
		EDataType EFeatureMap { get; }
		EDataType EFeatureMapEntry { get; }
		EDataType EFloat { get; }
		EDataType EFloatObject { get; }
		EDataType EInt { get; }
		EDataType EIntegerObject { get; }
		EDataType EJavaClass { get; }
		EDataType EJavaObject { get; }
		EDataType ELong { get; }
		EDataType ELongObject { get; }
		EDataType EMap { get; }
		EDataType EResource { get; }
		EDataType EResourceSet { get; }
		EDataType EShort { get; }
		EDataType EShortObject { get; }
		EDataType EString { get; }
		EDataType ETreeIterator { get; }
		EDataType EInvocationTargetException { get; }
	}
	
	public class ECorePackageImpl : ECorePackage {
		public ECorePackageImpl() {
			EAttribute = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEClass();
			EAttribute.Name = "EAttribute";
			EAttribute_iD = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EAttribute_iD.Name = "iD";
			EAttribute_iD.LowerBound = 0;
			EAttribute_iD.UpperBound = 1;
			EAttribute_iD.EType = ECoreMeta.cINSTANCE.Package.EBoolean;
			EAttribute.EStructuralFeatures.Add(EAttribute_iD);
					
			EAnnotation = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEClass();
			EAnnotation.Name = "EAnnotation";
			EAnnotation_source = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EAnnotation_source.Name = "source";
			EAnnotation_source.LowerBound = 0;
			EAnnotation_source.UpperBound = 1;
			EAnnotation_source.EType = ECoreMeta.cINSTANCE.Package.EString;
			EAnnotation.EStructuralFeatures.Add(EAnnotation_source);
			EAnnotation_details = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EAnnotation_details.Name = "details";
			EAnnotation_details.LowerBound = 0;
			EAnnotation_details.UpperBound = -1;
			EAnnotation_details.EType = ECoreMeta.cINSTANCE.Package.EStringToStringMapEntry;
			EAnnotation.EStructuralFeatures.Add(EAnnotation_details);
			EAnnotation_eModelElement = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EAnnotation_eModelElement.Name = "eModelElement";
			EAnnotation_eModelElement.LowerBound = 0;
			EAnnotation_eModelElement.UpperBound = 1;
			EAnnotation_eModelElement.EType = ECoreMeta.cINSTANCE.Package.EModelElement;
			EAnnotation.EStructuralFeatures.Add(EAnnotation_eModelElement);
			EAnnotation_contents = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EAnnotation_contents.Name = "contents";
			EAnnotation_contents.LowerBound = 0;
			EAnnotation_contents.UpperBound = -1;
			EAnnotation_contents.EType = ECoreMeta.cINSTANCE.Package.EObject;
			EAnnotation.EStructuralFeatures.Add(EAnnotation_contents);
			EAnnotation_references = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EAnnotation_references.Name = "references";
			EAnnotation_references.LowerBound = 0;
			EAnnotation_references.UpperBound = -1;
			EAnnotation_references.EType = ECoreMeta.cINSTANCE.Package.EObject;
			EAnnotation.EStructuralFeatures.Add(EAnnotation_references);
					
			EClass = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEClass();
			EClass.Name = "EClass";
			EClass_abstract = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EClass_abstract.Name = "abstract";
			EClass_abstract.LowerBound = 0;
			EClass_abstract.UpperBound = 1;
			EClass_abstract.EType = ECoreMeta.cINSTANCE.Package.EBoolean;
			EClass.EStructuralFeatures.Add(EClass_abstract);
			EClass_interface = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EClass_interface.Name = "interface";
			EClass_interface.LowerBound = 0;
			EClass_interface.UpperBound = 1;
			EClass_interface.EType = ECoreMeta.cINSTANCE.Package.EBoolean;
			EClass.EStructuralFeatures.Add(EClass_interface);
			EClass_eSuperTypes = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EClass_eSuperTypes.Name = "eSuperTypes";
			EClass_eSuperTypes.LowerBound = 0;
			EClass_eSuperTypes.UpperBound = -1;
			EClass_eSuperTypes.EType = ECoreMeta.cINSTANCE.Package.EClass;
			EClass.EStructuralFeatures.Add(EClass_eSuperTypes);
			EClass_eOperations = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EClass_eOperations.Name = "eOperations";
			EClass_eOperations.LowerBound = 0;
			EClass_eOperations.UpperBound = -1;
			EClass_eOperations.EType = ECoreMeta.cINSTANCE.Package.EOperation;
			EClass.EStructuralFeatures.Add(EClass_eOperations);
			EClass_eStructuralFeatures = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EClass_eStructuralFeatures.Name = "eStructuralFeatures";
			EClass_eStructuralFeatures.LowerBound = 0;
			EClass_eStructuralFeatures.UpperBound = -1;
			EClass_eStructuralFeatures.EType = ECoreMeta.cINSTANCE.Package.EStructuralFeature;
			EClass.EStructuralFeatures.Add(EClass_eStructuralFeatures);
			EClass_eGenericSuperTypes = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EClass_eGenericSuperTypes.Name = "eGenericSuperTypes";
			EClass_eGenericSuperTypes.LowerBound = 0;
			EClass_eGenericSuperTypes.UpperBound = -1;
			EClass_eGenericSuperTypes.EType = ECoreMeta.cINSTANCE.Package.EGenericType;
			EClass.EStructuralFeatures.Add(EClass_eGenericSuperTypes);
					
			EClassifier = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEClass();
			EClassifier.Name = "EClassifier";
			EClassifier_instanceClassName = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EClassifier_instanceClassName.Name = "instanceClassName";
			EClassifier_instanceClassName.LowerBound = 0;
			EClassifier_instanceClassName.UpperBound = 1;
			EClassifier_instanceClassName.EType = ECoreMeta.cINSTANCE.Package.EString;
			EClassifier.EStructuralFeatures.Add(EClassifier_instanceClassName);
			EClassifier_instanceTypeName = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EClassifier_instanceTypeName.Name = "instanceTypeName";
			EClassifier_instanceTypeName.LowerBound = 0;
			EClassifier_instanceTypeName.UpperBound = 1;
			EClassifier_instanceTypeName.EType = ECoreMeta.cINSTANCE.Package.EString;
			EClassifier.EStructuralFeatures.Add(EClassifier_instanceTypeName);
			EClassifier_ePackage = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EClassifier_ePackage.Name = "ePackage";
			EClassifier_ePackage.LowerBound = 0;
			EClassifier_ePackage.UpperBound = 1;
			EClassifier_ePackage.EType = ECoreMeta.cINSTANCE.Package.EPackage;
			EClassifier.EStructuralFeatures.Add(EClassifier_ePackage);
			EClassifier_eTypeParameters = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EClassifier_eTypeParameters.Name = "eTypeParameters";
			EClassifier_eTypeParameters.LowerBound = 0;
			EClassifier_eTypeParameters.UpperBound = -1;
			EClassifier_eTypeParameters.EType = ECoreMeta.cINSTANCE.Package.ETypeParameter;
			EClassifier.EStructuralFeatures.Add(EClassifier_eTypeParameters);
					
			EDataType = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEClass();
			EDataType.Name = "EDataType";
			EDataType_serializable = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EDataType_serializable.Name = "serializable";
			EDataType_serializable.LowerBound = 0;
			EDataType_serializable.UpperBound = 1;
			EDataType_serializable.EType = ECoreMeta.cINSTANCE.Package.EBoolean;
			EDataType.EStructuralFeatures.Add(EDataType_serializable);
					
			EEnum = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEClass();
			EEnum.Name = "EEnum";
			EEnum_eLiterals = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EEnum_eLiterals.Name = "eLiterals";
			EEnum_eLiterals.LowerBound = 0;
			EEnum_eLiterals.UpperBound = -1;
			EEnum_eLiterals.EType = ECoreMeta.cINSTANCE.Package.EEnumLiteral;
			EEnum.EStructuralFeatures.Add(EEnum_eLiterals);
					
			EEnumLiteral = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEClass();
			EEnumLiteral.Name = "EEnumLiteral";
			EEnumLiteral_value = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EEnumLiteral_value.Name = "value";
			EEnumLiteral_value.LowerBound = 0;
			EEnumLiteral_value.UpperBound = 1;
			EEnumLiteral_value.EType = ECoreMeta.cINSTANCE.Package.EInt;
			EEnumLiteral.EStructuralFeatures.Add(EEnumLiteral_value);
			EEnumLiteral_literal = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EEnumLiteral_literal.Name = "literal";
			EEnumLiteral_literal.LowerBound = 0;
			EEnumLiteral_literal.UpperBound = 1;
			EEnumLiteral_literal.EType = ECoreMeta.cINSTANCE.Package.EString;
			EEnumLiteral.EStructuralFeatures.Add(EEnumLiteral_literal);
			EEnumLiteral_eEnum = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EEnumLiteral_eEnum.Name = "eEnum";
			EEnumLiteral_eEnum.LowerBound = 0;
			EEnumLiteral_eEnum.UpperBound = 1;
			EEnumLiteral_eEnum.EType = ECoreMeta.cINSTANCE.Package.EEnum;
			EEnumLiteral.EStructuralFeatures.Add(EEnumLiteral_eEnum);
					
			EFactory = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEClass();
			EFactory.Name = "EFactory";
			EFactory_ePackage = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EFactory_ePackage.Name = "ePackage";
			EFactory_ePackage.LowerBound = 1;
			EFactory_ePackage.UpperBound = 1;
			EFactory_ePackage.EType = ECoreMeta.cINSTANCE.Package.EPackage;
			EFactory.EStructuralFeatures.Add(EFactory_ePackage);
					
			EModelElement = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEClass();
			EModelElement.Name = "EModelElement";
			EModelElement_eAnnotations = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EModelElement_eAnnotations.Name = "eAnnotations";
			EModelElement_eAnnotations.LowerBound = 0;
			EModelElement_eAnnotations.UpperBound = -1;
			EModelElement_eAnnotations.EType = ECoreMeta.cINSTANCE.Package.EAnnotation;
			EModelElement.EStructuralFeatures.Add(EModelElement_eAnnotations);
					
			ENamedElement = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEClass();
			ENamedElement.Name = "ENamedElement";
			ENamedElement_name = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			ENamedElement_name.Name = "name";
			ENamedElement_name.LowerBound = 0;
			ENamedElement_name.UpperBound = 1;
			ENamedElement_name.EType = ECoreMeta.cINSTANCE.Package.EString;
			ENamedElement.EStructuralFeatures.Add(ENamedElement_name);
					
			EObject = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEClass();
			EObject.Name = "EObject";
					
			EOperation = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEClass();
			EOperation.Name = "EOperation";
			EOperation_eContainingClass = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EOperation_eContainingClass.Name = "eContainingClass";
			EOperation_eContainingClass.LowerBound = 0;
			EOperation_eContainingClass.UpperBound = 1;
			EOperation_eContainingClass.EType = ECoreMeta.cINSTANCE.Package.EClass;
			EOperation.EStructuralFeatures.Add(EOperation_eContainingClass);
			EOperation_eTypeParameters = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EOperation_eTypeParameters.Name = "eTypeParameters";
			EOperation_eTypeParameters.LowerBound = 0;
			EOperation_eTypeParameters.UpperBound = -1;
			EOperation_eTypeParameters.EType = ECoreMeta.cINSTANCE.Package.ETypeParameter;
			EOperation.EStructuralFeatures.Add(EOperation_eTypeParameters);
			EOperation_eParameters = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EOperation_eParameters.Name = "eParameters";
			EOperation_eParameters.LowerBound = 0;
			EOperation_eParameters.UpperBound = -1;
			EOperation_eParameters.EType = ECoreMeta.cINSTANCE.Package.EParameter;
			EOperation.EStructuralFeatures.Add(EOperation_eParameters);
			EOperation_eExceptions = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EOperation_eExceptions.Name = "eExceptions";
			EOperation_eExceptions.LowerBound = 0;
			EOperation_eExceptions.UpperBound = -1;
			EOperation_eExceptions.EType = ECoreMeta.cINSTANCE.Package.EClassifier;
			EOperation.EStructuralFeatures.Add(EOperation_eExceptions);
			EOperation_eGenericExceptions = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EOperation_eGenericExceptions.Name = "eGenericExceptions";
			EOperation_eGenericExceptions.LowerBound = 0;
			EOperation_eGenericExceptions.UpperBound = -1;
			EOperation_eGenericExceptions.EType = ECoreMeta.cINSTANCE.Package.EGenericType;
			EOperation.EStructuralFeatures.Add(EOperation_eGenericExceptions);
					
			EPackage = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEClass();
			EPackage.Name = "EPackage";
			EPackage_nsURI = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EPackage_nsURI.Name = "nsURI";
			EPackage_nsURI.LowerBound = 0;
			EPackage_nsURI.UpperBound = 1;
			EPackage_nsURI.EType = ECoreMeta.cINSTANCE.Package.EString;
			EPackage.EStructuralFeatures.Add(EPackage_nsURI);
			EPackage_nsPrefix = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EPackage_nsPrefix.Name = "nsPrefix";
			EPackage_nsPrefix.LowerBound = 0;
			EPackage_nsPrefix.UpperBound = 1;
			EPackage_nsPrefix.EType = ECoreMeta.cINSTANCE.Package.EString;
			EPackage.EStructuralFeatures.Add(EPackage_nsPrefix);
			EPackage_eFactoryInstance = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EPackage_eFactoryInstance.Name = "eFactoryInstance";
			EPackage_eFactoryInstance.LowerBound = 1;
			EPackage_eFactoryInstance.UpperBound = 1;
			EPackage_eFactoryInstance.EType = ECoreMeta.cINSTANCE.Package.EFactory;
			EPackage.EStructuralFeatures.Add(EPackage_eFactoryInstance);
			EPackage_eClassifiers = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EPackage_eClassifiers.Name = "eClassifiers";
			EPackage_eClassifiers.LowerBound = 0;
			EPackage_eClassifiers.UpperBound = -1;
			EPackage_eClassifiers.EType = ECoreMeta.cINSTANCE.Package.EClassifier;
			EPackage.EStructuralFeatures.Add(EPackage_eClassifiers);
			EPackage_eSubpackages = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EPackage_eSubpackages.Name = "eSubpackages";
			EPackage_eSubpackages.LowerBound = 0;
			EPackage_eSubpackages.UpperBound = -1;
			EPackage_eSubpackages.EType = ECoreMeta.cINSTANCE.Package.EPackage;
			EPackage.EStructuralFeatures.Add(EPackage_eSubpackages);
			EPackage_eSuperPackage = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EPackage_eSuperPackage.Name = "eSuperPackage";
			EPackage_eSuperPackage.LowerBound = 0;
			EPackage_eSuperPackage.UpperBound = 1;
			EPackage_eSuperPackage.EType = ECoreMeta.cINSTANCE.Package.EPackage;
			EPackage.EStructuralFeatures.Add(EPackage_eSuperPackage);
					
			EParameter = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEClass();
			EParameter.Name = "EParameter";
			EParameter_eOperation = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EParameter_eOperation.Name = "eOperation";
			EParameter_eOperation.LowerBound = 0;
			EParameter_eOperation.UpperBound = 1;
			EParameter_eOperation.EType = ECoreMeta.cINSTANCE.Package.EOperation;
			EParameter.EStructuralFeatures.Add(EParameter_eOperation);
					
			EReference = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEClass();
			EReference.Name = "EReference";
			EReference_containment = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EReference_containment.Name = "containment";
			EReference_containment.LowerBound = 0;
			EReference_containment.UpperBound = 1;
			EReference_containment.EType = ECoreMeta.cINSTANCE.Package.EBoolean;
			EReference.EStructuralFeatures.Add(EReference_containment);
			EReference_resolveProxies = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EReference_resolveProxies.Name = "resolveProxies";
			EReference_resolveProxies.LowerBound = 0;
			EReference_resolveProxies.UpperBound = 1;
			EReference_resolveProxies.EType = ECoreMeta.cINSTANCE.Package.EBoolean;
			EReference.EStructuralFeatures.Add(EReference_resolveProxies);
			EReference_eOpposite = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EReference_eOpposite.Name = "eOpposite";
			EReference_eOpposite.LowerBound = 0;
			EReference_eOpposite.UpperBound = 1;
			EReference_eOpposite.EType = ECoreMeta.cINSTANCE.Package.EReference;
			EReference.EStructuralFeatures.Add(EReference_eOpposite);
			EReference_eKeys = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EReference_eKeys.Name = "eKeys";
			EReference_eKeys.LowerBound = 0;
			EReference_eKeys.UpperBound = -1;
			EReference_eKeys.EType = ECoreMeta.cINSTANCE.Package.EAttribute;
			EReference.EStructuralFeatures.Add(EReference_eKeys);
					
			EStructuralFeature = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEClass();
			EStructuralFeature.Name = "EStructuralFeature";
			EStructuralFeature_changeable = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EStructuralFeature_changeable.Name = "changeable";
			EStructuralFeature_changeable.LowerBound = 0;
			EStructuralFeature_changeable.UpperBound = 1;
			EStructuralFeature_changeable.EType = ECoreMeta.cINSTANCE.Package.EBoolean;
			EStructuralFeature.EStructuralFeatures.Add(EStructuralFeature_changeable);
			EStructuralFeature_volatile = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EStructuralFeature_volatile.Name = "volatile";
			EStructuralFeature_volatile.LowerBound = 0;
			EStructuralFeature_volatile.UpperBound = 1;
			EStructuralFeature_volatile.EType = ECoreMeta.cINSTANCE.Package.EBoolean;
			EStructuralFeature.EStructuralFeatures.Add(EStructuralFeature_volatile);
			EStructuralFeature_transient = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EStructuralFeature_transient.Name = "transient";
			EStructuralFeature_transient.LowerBound = 0;
			EStructuralFeature_transient.UpperBound = 1;
			EStructuralFeature_transient.EType = ECoreMeta.cINSTANCE.Package.EBoolean;
			EStructuralFeature.EStructuralFeatures.Add(EStructuralFeature_transient);
			EStructuralFeature_defaultValueLiteral = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EStructuralFeature_defaultValueLiteral.Name = "defaultValueLiteral";
			EStructuralFeature_defaultValueLiteral.LowerBound = 0;
			EStructuralFeature_defaultValueLiteral.UpperBound = 1;
			EStructuralFeature_defaultValueLiteral.EType = ECoreMeta.cINSTANCE.Package.EString;
			EStructuralFeature.EStructuralFeatures.Add(EStructuralFeature_defaultValueLiteral);
			EStructuralFeature_unsettable = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EStructuralFeature_unsettable.Name = "unsettable";
			EStructuralFeature_unsettable.LowerBound = 0;
			EStructuralFeature_unsettable.UpperBound = 1;
			EStructuralFeature_unsettable.EType = ECoreMeta.cINSTANCE.Package.EBoolean;
			EStructuralFeature.EStructuralFeatures.Add(EStructuralFeature_unsettable);
			EStructuralFeature_derived = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EStructuralFeature_derived.Name = "derived";
			EStructuralFeature_derived.LowerBound = 0;
			EStructuralFeature_derived.UpperBound = 1;
			EStructuralFeature_derived.EType = ECoreMeta.cINSTANCE.Package.EBoolean;
			EStructuralFeature.EStructuralFeatures.Add(EStructuralFeature_derived);
			EStructuralFeature_eContainingClass = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EStructuralFeature_eContainingClass.Name = "eContainingClass";
			EStructuralFeature_eContainingClass.LowerBound = 0;
			EStructuralFeature_eContainingClass.UpperBound = 1;
			EStructuralFeature_eContainingClass.EType = ECoreMeta.cINSTANCE.Package.EClass;
			EStructuralFeature.EStructuralFeatures.Add(EStructuralFeature_eContainingClass);
					
			ETypedElement = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEClass();
			ETypedElement.Name = "ETypedElement";
			ETypedElement_ordered = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			ETypedElement_ordered.Name = "ordered";
			ETypedElement_ordered.LowerBound = 0;
			ETypedElement_ordered.UpperBound = 1;
			ETypedElement_ordered.EType = ECoreMeta.cINSTANCE.Package.EBoolean;
			ETypedElement.EStructuralFeatures.Add(ETypedElement_ordered);
			ETypedElement_unique = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			ETypedElement_unique.Name = "unique";
			ETypedElement_unique.LowerBound = 0;
			ETypedElement_unique.UpperBound = 1;
			ETypedElement_unique.EType = ECoreMeta.cINSTANCE.Package.EBoolean;
			ETypedElement.EStructuralFeatures.Add(ETypedElement_unique);
			ETypedElement_lowerBound = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			ETypedElement_lowerBound.Name = "lowerBound";
			ETypedElement_lowerBound.LowerBound = 0;
			ETypedElement_lowerBound.UpperBound = 1;
			ETypedElement_lowerBound.EType = ECoreMeta.cINSTANCE.Package.EInt;
			ETypedElement.EStructuralFeatures.Add(ETypedElement_lowerBound);
			ETypedElement_upperBound = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			ETypedElement_upperBound.Name = "upperBound";
			ETypedElement_upperBound.LowerBound = 0;
			ETypedElement_upperBound.UpperBound = 1;
			ETypedElement_upperBound.EType = ECoreMeta.cINSTANCE.Package.EInt;
			ETypedElement.EStructuralFeatures.Add(ETypedElement_upperBound);
			ETypedElement_eType = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			ETypedElement_eType.Name = "eType";
			ETypedElement_eType.LowerBound = 0;
			ETypedElement_eType.UpperBound = 1;
			ETypedElement_eType.EType = ECoreMeta.cINSTANCE.Package.EClassifier;
			ETypedElement.EStructuralFeatures.Add(ETypedElement_eType);
			ETypedElement_eGenericType = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			ETypedElement_eGenericType.Name = "eGenericType";
			ETypedElement_eGenericType.LowerBound = 0;
			ETypedElement_eGenericType.UpperBound = 1;
			ETypedElement_eGenericType.EType = ECoreMeta.cINSTANCE.Package.EGenericType;
			ETypedElement.EStructuralFeatures.Add(ETypedElement_eGenericType);
					
			EStringToStringMapEntry = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEClass();
			EStringToStringMapEntry.Name = "EStringToStringMapEntry";
			EStringToStringMapEntry_key = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EStringToStringMapEntry_key.Name = "key";
			EStringToStringMapEntry_key.LowerBound = 0;
			EStringToStringMapEntry_key.UpperBound = 1;
			EStringToStringMapEntry_key.EType = ECoreMeta.cINSTANCE.Package.EString;
			EStringToStringMapEntry.EStructuralFeatures.Add(EStringToStringMapEntry_key);
			EStringToStringMapEntry_value = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EStringToStringMapEntry_value.Name = "value";
			EStringToStringMapEntry_value.LowerBound = 0;
			EStringToStringMapEntry_value.UpperBound = 1;
			EStringToStringMapEntry_value.EType = ECoreMeta.cINSTANCE.Package.EString;
			EStringToStringMapEntry.EStructuralFeatures.Add(EStringToStringMapEntry_value);
					
			EGenericType = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEClass();
			EGenericType.Name = "EGenericType";
			EGenericType_eUpperBound = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EGenericType_eUpperBound.Name = "eUpperBound";
			EGenericType_eUpperBound.LowerBound = 0;
			EGenericType_eUpperBound.UpperBound = 1;
			EGenericType_eUpperBound.EType = ECoreMeta.cINSTANCE.Package.EGenericType;
			EGenericType.EStructuralFeatures.Add(EGenericType_eUpperBound);
			EGenericType_eTypeArguments = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EGenericType_eTypeArguments.Name = "eTypeArguments";
			EGenericType_eTypeArguments.LowerBound = 0;
			EGenericType_eTypeArguments.UpperBound = -1;
			EGenericType_eTypeArguments.EType = ECoreMeta.cINSTANCE.Package.EGenericType;
			EGenericType.EStructuralFeatures.Add(EGenericType_eTypeArguments);
			EGenericType_eLowerBound = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EGenericType_eLowerBound.Name = "eLowerBound";
			EGenericType_eLowerBound.LowerBound = 0;
			EGenericType_eLowerBound.UpperBound = 1;
			EGenericType_eLowerBound.EType = ECoreMeta.cINSTANCE.Package.EGenericType;
			EGenericType.EStructuralFeatures.Add(EGenericType_eLowerBound);
			EGenericType_eTypeParameter = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EGenericType_eTypeParameter.Name = "eTypeParameter";
			EGenericType_eTypeParameter.LowerBound = 0;
			EGenericType_eTypeParameter.UpperBound = 1;
			EGenericType_eTypeParameter.EType = ECoreMeta.cINSTANCE.Package.ETypeParameter;
			EGenericType.EStructuralFeatures.Add(EGenericType_eTypeParameter);
			EGenericType_eClassifier = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EGenericType_eClassifier.Name = "eClassifier";
			EGenericType_eClassifier.LowerBound = 0;
			EGenericType_eClassifier.UpperBound = 1;
			EGenericType_eClassifier.EType = ECoreMeta.cINSTANCE.Package.EClassifier;
			EGenericType.EStructuralFeatures.Add(EGenericType_eClassifier);
					
			ETypeParameter = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEClass();
			ETypeParameter.Name = "ETypeParameter";
			ETypeParameter_eBounds = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			ETypeParameter_eBounds.Name = "eBounds";
			ETypeParameter_eBounds.LowerBound = 0;
			ETypeParameter_eBounds.UpperBound = -1;
			ETypeParameter_eBounds.EType = ECoreMeta.cINSTANCE.Package.EGenericType;
			ETypeParameter.EStructuralFeatures.Add(ETypeParameter_eBounds);
					
			EBigDecimal = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEDataType();
			EBigDecimal.Name = "EBigDecimal";
			EBigInteger = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEDataType();
			EBigInteger.Name = "EBigInteger";
			EBoolean = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEDataType();
			EBoolean.Name = "EBoolean";
			EBooleanObject = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEDataType();
			EBooleanObject.Name = "EBooleanObject";
			EByte = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEDataType();
			EByte.Name = "EByte";
			EByteArray = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEDataType();
			EByteArray.Name = "EByteArray";
			EByteObject = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEDataType();
			EByteObject.Name = "EByteObject";
			EChar = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEDataType();
			EChar.Name = "EChar";
			ECharacterObject = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEDataType();
			ECharacterObject.Name = "ECharacterObject";
			EDate = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEDataType();
			EDate.Name = "EDate";
			EDiagnosticChain = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEDataType();
			EDiagnosticChain.Name = "EDiagnosticChain";
			EDouble = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEDataType();
			EDouble.Name = "EDouble";
			EDoubleObject = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEDataType();
			EDoubleObject.Name = "EDoubleObject";
			EEList = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEDataType();
			EEList.Name = "EEList";
			EEnumerator = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEDataType();
			EEnumerator.Name = "EEnumerator";
			EFeatureMap = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEDataType();
			EFeatureMap.Name = "EFeatureMap";
			EFeatureMapEntry = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEDataType();
			EFeatureMapEntry.Name = "EFeatureMapEntry";
			EFloat = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEDataType();
			EFloat.Name = "EFloat";
			EFloatObject = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEDataType();
			EFloatObject.Name = "EFloatObject";
			EInt = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEDataType();
			EInt.Name = "EInt";
			EIntegerObject = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEDataType();
			EIntegerObject.Name = "EIntegerObject";
			EJavaClass = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEDataType();
			EJavaClass.Name = "EJavaClass";
			EJavaObject = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEDataType();
			EJavaObject.Name = "EJavaObject";
			ELong = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEDataType();
			ELong.Name = "ELong";
			ELongObject = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEDataType();
			ELongObject.Name = "ELongObject";
			EMap = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEDataType();
			EMap.Name = "EMap";
			EResource = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEDataType();
			EResource.Name = "EResource";
			EResourceSet = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEDataType();
			EResourceSet.Name = "EResourceSet";
			EShort = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEDataType();
			EShort.Name = "EShort";
			EShortObject = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEDataType();
			EShortObject.Name = "EShortObject";
			EString = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEDataType();
			EString.Name = "EString";
			ETreeIterator = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEDataType();
			ETreeIterator.Name = "ETreeIterator";
			EInvocationTargetException = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEDataType();
			EInvocationTargetException.Name = "EInvocationTargetException";
		}
		
		public EClass EAttribute { get; private set;}
		public EStructuralFeature EAttribute_iD  { get; private set;}
		public EClass EAnnotation { get; private set;}
		public EStructuralFeature EAnnotation_source  { get; private set;}
		public EStructuralFeature EAnnotation_details  { get; private set;}
		public EStructuralFeature EAnnotation_eModelElement  { get; private set;}
		public EStructuralFeature EAnnotation_contents  { get; private set;}
		public EStructuralFeature EAnnotation_references  { get; private set;}
		public EClass EClass { get; private set;}
		public EStructuralFeature EClass_abstract  { get; private set;}
		public EStructuralFeature EClass_interface  { get; private set;}
		public EStructuralFeature EClass_eSuperTypes  { get; private set;}
		public EStructuralFeature EClass_eOperations  { get; private set;}
		public EStructuralFeature EClass_eStructuralFeatures  { get; private set;}
		public EStructuralFeature EClass_eGenericSuperTypes  { get; private set;}
		public EClass EClassifier { get; private set;}
		public EStructuralFeature EClassifier_instanceClassName  { get; private set;}
		public EStructuralFeature EClassifier_instanceTypeName  { get; private set;}
		public EStructuralFeature EClassifier_ePackage  { get; private set;}
		public EStructuralFeature EClassifier_eTypeParameters  { get; private set;}
		public EClass EDataType { get; private set;}
		public EStructuralFeature EDataType_serializable  { get; private set;}
		public EClass EEnum { get; private set;}
		public EStructuralFeature EEnum_eLiterals  { get; private set;}
		public EClass EEnumLiteral { get; private set;}
		public EStructuralFeature EEnumLiteral_value  { get; private set;}
		public EStructuralFeature EEnumLiteral_literal  { get; private set;}
		public EStructuralFeature EEnumLiteral_eEnum  { get; private set;}
		public EClass EFactory { get; private set;}
		public EStructuralFeature EFactory_ePackage  { get; private set;}
		public EClass EModelElement { get; private set;}
		public EStructuralFeature EModelElement_eAnnotations  { get; private set;}
		public EClass ENamedElement { get; private set;}
		public EStructuralFeature ENamedElement_name  { get; private set;}
		public EClass EObject { get; private set;}
		public EClass EOperation { get; private set;}
		public EStructuralFeature EOperation_eContainingClass  { get; private set;}
		public EStructuralFeature EOperation_eTypeParameters  { get; private set;}
		public EStructuralFeature EOperation_eParameters  { get; private set;}
		public EStructuralFeature EOperation_eExceptions  { get; private set;}
		public EStructuralFeature EOperation_eGenericExceptions  { get; private set;}
		public EClass EPackage { get; private set;}
		public EStructuralFeature EPackage_nsURI  { get; private set;}
		public EStructuralFeature EPackage_nsPrefix  { get; private set;}
		public EStructuralFeature EPackage_eFactoryInstance  { get; private set;}
		public EStructuralFeature EPackage_eClassifiers  { get; private set;}
		public EStructuralFeature EPackage_eSubpackages  { get; private set;}
		public EStructuralFeature EPackage_eSuperPackage  { get; private set;}
		public EClass EParameter { get; private set;}
		public EStructuralFeature EParameter_eOperation  { get; private set;}
		public EClass EReference { get; private set;}
		public EStructuralFeature EReference_containment  { get; private set;}
		public EStructuralFeature EReference_resolveProxies  { get; private set;}
		public EStructuralFeature EReference_eOpposite  { get; private set;}
		public EStructuralFeature EReference_eKeys  { get; private set;}
		public EClass EStructuralFeature { get; private set;}
		public EStructuralFeature EStructuralFeature_changeable  { get; private set;}
		public EStructuralFeature EStructuralFeature_volatile  { get; private set;}
		public EStructuralFeature EStructuralFeature_transient  { get; private set;}
		public EStructuralFeature EStructuralFeature_defaultValueLiteral  { get; private set;}
		public EStructuralFeature EStructuralFeature_unsettable  { get; private set;}
		public EStructuralFeature EStructuralFeature_derived  { get; private set;}
		public EStructuralFeature EStructuralFeature_eContainingClass  { get; private set;}
		public EClass ETypedElement { get; private set;}
		public EStructuralFeature ETypedElement_ordered  { get; private set;}
		public EStructuralFeature ETypedElement_unique  { get; private set;}
		public EStructuralFeature ETypedElement_lowerBound  { get; private set;}
		public EStructuralFeature ETypedElement_upperBound  { get; private set;}
		public EStructuralFeature ETypedElement_eType  { get; private set;}
		public EStructuralFeature ETypedElement_eGenericType  { get; private set;}
		public EClass EStringToStringMapEntry { get; private set;}
		public EStructuralFeature EStringToStringMapEntry_key  { get; private set;}
		public EStructuralFeature EStringToStringMapEntry_value  { get; private set;}
		public EClass EGenericType { get; private set;}
		public EStructuralFeature EGenericType_eUpperBound  { get; private set;}
		public EStructuralFeature EGenericType_eTypeArguments  { get; private set;}
		public EStructuralFeature EGenericType_eLowerBound  { get; private set;}
		public EStructuralFeature EGenericType_eTypeParameter  { get; private set;}
		public EStructuralFeature EGenericType_eClassifier  { get; private set;}
		public EClass ETypeParameter { get; private set;}
		public EStructuralFeature ETypeParameter_eBounds  { get; private set;}
		public EDataType EBigDecimal { get; private set;}		
		public EDataType EBigInteger { get; private set;}		
		public EDataType EBoolean { get; private set;}		
		public EDataType EBooleanObject { get; private set;}		
		public EDataType EByte { get; private set;}		
		public EDataType EByteArray { get; private set;}		
		public EDataType EByteObject { get; private set;}		
		public EDataType EChar { get; private set;}		
		public EDataType ECharacterObject { get; private set;}		
		public EDataType EDate { get; private set;}		
		public EDataType EDiagnosticChain { get; private set;}		
		public EDataType EDouble { get; private set;}		
		public EDataType EDoubleObject { get; private set;}		
		public EDataType EEList { get; private set;}		
		public EDataType EEnumerator { get; private set;}		
		public EDataType EFeatureMap { get; private set;}		
		public EDataType EFeatureMapEntry { get; private set;}		
		public EDataType EFloat { get; private set;}		
		public EDataType EFloatObject { get; private set;}		
		public EDataType EInt { get; private set;}		
		public EDataType EIntegerObject { get; private set;}		
		public EDataType EJavaClass { get; private set;}		
		public EDataType EJavaObject { get; private set;}		
		public EDataType ELong { get; private set;}		
		public EDataType ELongObject { get; private set;}		
		public EDataType EMap { get; private set;}		
		public EDataType EResource { get; private set;}		
		public EDataType EResourceSet { get; private set;}		
		public EDataType EShort { get; private set;}		
		public EDataType EShortObject { get; private set;}		
		public EDataType EString { get; private set;}		
		public EDataType ETreeIterator { get; private set;}		
		public EDataType EInvocationTargetException { get; private set;}		
	}
} // UnityCMF.ecore
