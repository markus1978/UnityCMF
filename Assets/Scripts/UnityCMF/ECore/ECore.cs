using UnityCMF.CCore;

namespace UnityCMF.ECore {
	
	public sealed class ECoreMeta {
		public static ECoreMeta cINSTANCE = new ECoreMeta();
		private ECorePackageImpl _package = new ECorePackageImpl();
		private ECoreFactoryImpl _factory = new ECoreFactoryImpl();
		public ECorePackage Package { 
			get {
				_package.init();
				return _package;
			}
		}
		public ECoreFactory Factory { 
			get {
				return _factory;
			} 
		}
	}
	public interface ECorePackage : CPackage {
		EClass EAttribute { get; }
		EStructuralFeature EAttribute_ID { get; }
		EStructuralFeature EAttribute_EAttributeType { get; }
		EClass EAnnotation { get; }
		EStructuralFeature EAnnotation_Source { get; }
		EStructuralFeature EAnnotation_Details { get; }
		EStructuralFeature EAnnotation_EModelElement { get; }
		EStructuralFeature EAnnotation_Contents { get; }
		EStructuralFeature EAnnotation_References { get; }
		EClass EClass { get; }
		EStructuralFeature EClass_Abstract { get; }
		EStructuralFeature EClass_Interface { get; }
		EStructuralFeature EClass_ESuperTypes { get; }
		EStructuralFeature EClass_EOperations { get; }
		EStructuralFeature EClass_EAllAttributes { get; }
		EStructuralFeature EClass_EAllReferences { get; }
		EStructuralFeature EClass_EReferences { get; }
		EStructuralFeature EClass_EAttributes { get; }
		EStructuralFeature EClass_EAllContainments { get; }
		EStructuralFeature EClass_EAllOperations { get; }
		EStructuralFeature EClass_EAllStructuralFeatures { get; }
		EStructuralFeature EClass_EAllSuperTypes { get; }
		EStructuralFeature EClass_EIDAttribute { get; }
		EStructuralFeature EClass_EStructuralFeatures { get; }
		EStructuralFeature EClass_EGenericSuperTypes { get; }
		EStructuralFeature EClass_EAllGenericSuperTypes { get; }
		EClass EClassifier { get; }
		EStructuralFeature EClassifier_InstanceClassName { get; }
		EStructuralFeature EClassifier_InstanceTypeName { get; }
		EStructuralFeature EClassifier_EPackage { get; }
		EStructuralFeature EClassifier_ETypeParameters { get; }
		EStructuralFeature EClassifier_CPackage { get; }
		EClass EDataType { get; }
		EStructuralFeature EDataType_Serializable { get; }
		EClass EEnum { get; }
		EStructuralFeature EEnum_ELiterals { get; }
		EClass EEnumLiteral { get; }
		EStructuralFeature EEnumLiteral_Value { get; }
		EStructuralFeature EEnumLiteral_Literal { get; }
		EStructuralFeature EEnumLiteral_EEnum { get; }
		EClass EFactory { get; }
		EStructuralFeature EFactory_EPackage { get; }
		EClass EModelElement { get; }
		EStructuralFeature EModelElement_EAnnotations { get; }
		EClass ENamedElement { get; }
		EStructuralFeature ENamedElement_Name { get; }
		EClass EObject { get; }
		EClass EOperation { get; }
		EStructuralFeature EOperation_EContainingClass { get; }
		EStructuralFeature EOperation_ETypeParameters { get; }
		EStructuralFeature EOperation_EParameters { get; }
		EStructuralFeature EOperation_EExceptions { get; }
		EStructuralFeature EOperation_EGenericExceptions { get; }
		EClass EPackage { get; }
		EStructuralFeature EPackage_NsURI { get; }
		EStructuralFeature EPackage_NsPrefix { get; }
		EStructuralFeature EPackage_EFactoryInstance { get; }
		EStructuralFeature EPackage_EClassifiers { get; }
		EStructuralFeature EPackage_ESubpackages { get; }
		EStructuralFeature EPackage_ESuperPackage { get; }
		EClass EParameter { get; }
		EStructuralFeature EParameter_EOperation { get; }
		EClass EReference { get; }
		EStructuralFeature EReference_Containment { get; }
		EStructuralFeature EReference_Container { get; }
		EStructuralFeature EReference_ResolveProxies { get; }
		EStructuralFeature EReference_EOpposite { get; }
		EStructuralFeature EReference_EReferenceType { get; }
		EStructuralFeature EReference_EKeys { get; }
		EClass EStructuralFeature { get; }
		EStructuralFeature EStructuralFeature_Changeable { get; }
		EStructuralFeature EStructuralFeature_Volatile { get; }
		EStructuralFeature EStructuralFeature_Transient { get; }
		EStructuralFeature EStructuralFeature_DefaultValueLiteral { get; }
		EStructuralFeature EStructuralFeature_Unsettable { get; }
		EStructuralFeature EStructuralFeature_Derived { get; }
		EStructuralFeature EStructuralFeature_EContainingClass { get; }
		EClass ETypedElement { get; }
		EStructuralFeature ETypedElement_Ordered { get; }
		EStructuralFeature ETypedElement_Unique { get; }
		EStructuralFeature ETypedElement_LowerBound { get; }
		EStructuralFeature ETypedElement_UpperBound { get; }
		EStructuralFeature ETypedElement_Many { get; }
		EStructuralFeature ETypedElement_Required { get; }
		EStructuralFeature ETypedElement_EType { get; }
		EStructuralFeature ETypedElement_EGenericType { get; }
		EClass EStringToStringMapEntry { get; }
		EStructuralFeature EStringToStringMapEntry_Key { get; }
		EStructuralFeature EStringToStringMapEntry_Value { get; }
		EClass EGenericType { get; }
		EStructuralFeature EGenericType_EUpperBound { get; }
		EStructuralFeature EGenericType_ETypeArguments { get; }
		EStructuralFeature EGenericType_ERawType { get; }
		EStructuralFeature EGenericType_ELowerBound { get; }
		EStructuralFeature EGenericType_ETypeParameter { get; }
		EStructuralFeature EGenericType_EClassifier { get; }
		EClass ETypeParameter { get; }
		EStructuralFeature ETypeParameter_EBounds { get; }
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
		public CFactory FactoryInstance {
			get {
				return ECoreMeta.cINSTANCE.Factory;
			}	
		}
		
		private bool _isInited = false;
		
		public void init() {
			if (_isInited) return;
			_isInited = true;				
			EAttribute = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEClass();
			EAttribute.Name = "EAttribute";
			EAttribute.CPackage = this;
			EAnnotation = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEClass();
			EAnnotation.Name = "EAnnotation";
			EAnnotation.CPackage = this;
			EClass = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEClass();
			EClass.Name = "EClass";
			EClass.CPackage = this;
			EClassifier = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEClass();
			EClassifier.Name = "EClassifier";
			EClassifier.CPackage = this;
			EDataType = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEClass();
			EDataType.Name = "EDataType";
			EDataType.CPackage = this;
			EEnum = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEClass();
			EEnum.Name = "EEnum";
			EEnum.CPackage = this;
			EEnumLiteral = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEClass();
			EEnumLiteral.Name = "EEnumLiteral";
			EEnumLiteral.CPackage = this;
			EFactory = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEClass();
			EFactory.Name = "EFactory";
			EFactory.CPackage = this;
			EModelElement = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEClass();
			EModelElement.Name = "EModelElement";
			EModelElement.CPackage = this;
			ENamedElement = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEClass();
			ENamedElement.Name = "ENamedElement";
			ENamedElement.CPackage = this;
			EObject = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEClass();
			EObject.Name = "EObject";
			EObject.CPackage = this;
			EOperation = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEClass();
			EOperation.Name = "EOperation";
			EOperation.CPackage = this;
			EPackage = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEClass();
			EPackage.Name = "EPackage";
			EPackage.CPackage = this;
			EParameter = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEClass();
			EParameter.Name = "EParameter";
			EParameter.CPackage = this;
			EReference = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEClass();
			EReference.Name = "EReference";
			EReference.CPackage = this;
			EStructuralFeature = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEClass();
			EStructuralFeature.Name = "EStructuralFeature";
			EStructuralFeature.CPackage = this;
			ETypedElement = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEClass();
			ETypedElement.Name = "ETypedElement";
			ETypedElement.CPackage = this;
			EStringToStringMapEntry = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEClass();
			EStringToStringMapEntry.Name = "EStringToStringMapEntry";
			EStringToStringMapEntry.CPackage = this;
			EGenericType = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEClass();
			EGenericType.Name = "EGenericType";
			EGenericType.CPackage = this;
			ETypeParameter = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEClass();
			ETypeParameter.Name = "ETypeParameter";
			ETypeParameter.CPackage = this;
			EBigDecimal = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEDataType();
			EBigDecimal.Name = "EBigDecimal";
			EBigDecimal.CPackage = this;
			EBigInteger = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEDataType();
			EBigInteger.Name = "EBigInteger";
			EBigInteger.CPackage = this;
			EBoolean = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEDataType();
			EBoolean.Name = "EBoolean";
			EBoolean.CPackage = this;
			EBooleanObject = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEDataType();
			EBooleanObject.Name = "EBooleanObject";
			EBooleanObject.CPackage = this;
			EByte = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEDataType();
			EByte.Name = "EByte";
			EByte.CPackage = this;
			EByteArray = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEDataType();
			EByteArray.Name = "EByteArray";
			EByteArray.CPackage = this;
			EByteObject = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEDataType();
			EByteObject.Name = "EByteObject";
			EByteObject.CPackage = this;
			EChar = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEDataType();
			EChar.Name = "EChar";
			EChar.CPackage = this;
			ECharacterObject = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEDataType();
			ECharacterObject.Name = "ECharacterObject";
			ECharacterObject.CPackage = this;
			EDate = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEDataType();
			EDate.Name = "EDate";
			EDate.CPackage = this;
			EDiagnosticChain = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEDataType();
			EDiagnosticChain.Name = "EDiagnosticChain";
			EDiagnosticChain.CPackage = this;
			EDouble = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEDataType();
			EDouble.Name = "EDouble";
			EDouble.CPackage = this;
			EDoubleObject = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEDataType();
			EDoubleObject.Name = "EDoubleObject";
			EDoubleObject.CPackage = this;
			EEList = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEDataType();
			EEList.Name = "EEList";
			EEList.CPackage = this;
			EEnumerator = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEDataType();
			EEnumerator.Name = "EEnumerator";
			EEnumerator.CPackage = this;
			EFeatureMap = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEDataType();
			EFeatureMap.Name = "EFeatureMap";
			EFeatureMap.CPackage = this;
			EFeatureMapEntry = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEDataType();
			EFeatureMapEntry.Name = "EFeatureMapEntry";
			EFeatureMapEntry.CPackage = this;
			EFloat = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEDataType();
			EFloat.Name = "EFloat";
			EFloat.CPackage = this;
			EFloatObject = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEDataType();
			EFloatObject.Name = "EFloatObject";
			EFloatObject.CPackage = this;
			EInt = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEDataType();
			EInt.Name = "EInt";
			EInt.CPackage = this;
			EIntegerObject = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEDataType();
			EIntegerObject.Name = "EIntegerObject";
			EIntegerObject.CPackage = this;
			EJavaClass = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEDataType();
			EJavaClass.Name = "EJavaClass";
			EJavaClass.CPackage = this;
			EJavaObject = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEDataType();
			EJavaObject.Name = "EJavaObject";
			EJavaObject.CPackage = this;
			ELong = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEDataType();
			ELong.Name = "ELong";
			ELong.CPackage = this;
			ELongObject = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEDataType();
			ELongObject.Name = "ELongObject";
			ELongObject.CPackage = this;
			EMap = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEDataType();
			EMap.Name = "EMap";
			EMap.CPackage = this;
			EResource = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEDataType();
			EResource.Name = "EResource";
			EResource.CPackage = this;
			EResourceSet = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEDataType();
			EResourceSet.Name = "EResourceSet";
			EResourceSet.CPackage = this;
			EShort = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEDataType();
			EShort.Name = "EShort";
			EShort.CPackage = this;
			EShortObject = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEDataType();
			EShortObject.Name = "EShortObject";
			EShortObject.CPackage = this;
			EString = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEDataType();
			EString.Name = "EString";
			EString.CPackage = this;
			ETreeIterator = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEDataType();
			ETreeIterator.Name = "ETreeIterator";
			ETreeIterator.CPackage = this;
			EInvocationTargetException = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEDataType();
			EInvocationTargetException.Name = "EInvocationTargetException";
			EInvocationTargetException.CPackage = this;
			EAttribute_ID = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EAttribute_ID.Name = "iD";
			EAttribute_ID.LowerBound = 0;
			EAttribute_ID.UpperBound = 1;
			EAttribute_ID.EType = this.EBoolean;
			EAttribute.EStructuralFeatures.Add(EAttribute_ID);
			EAttribute_EAttributeType = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EAttribute_EAttributeType.Name = "eAttributeType";
			EAttribute_EAttributeType.LowerBound = 1;
			EAttribute_EAttributeType.UpperBound = 1;
			EAttribute_EAttributeType.EType = this.EDataType;
			EAttribute.EStructuralFeatures.Add(EAttribute_EAttributeType);
			EAnnotation_Source = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EAnnotation_Source.Name = "source";
			EAnnotation_Source.LowerBound = 0;
			EAnnotation_Source.UpperBound = 1;
			EAnnotation_Source.EType = this.EString;
			EAnnotation.EStructuralFeatures.Add(EAnnotation_Source);
			EAnnotation_Details = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EAnnotation_Details.Name = "details";
			EAnnotation_Details.LowerBound = 0;
			EAnnotation_Details.UpperBound = -1;
			EAnnotation_Details.EType = this.EStringToStringMapEntry;
			EAnnotation.EStructuralFeatures.Add(EAnnotation_Details);
			EAnnotation_EModelElement = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EAnnotation_EModelElement.Name = "eModelElement";
			EAnnotation_EModelElement.LowerBound = 0;
			EAnnotation_EModelElement.UpperBound = 1;
			EAnnotation_EModelElement.EType = this.EModelElement;
			EAnnotation.EStructuralFeatures.Add(EAnnotation_EModelElement);
			EAnnotation_Contents = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EAnnotation_Contents.Name = "contents";
			EAnnotation_Contents.LowerBound = 0;
			EAnnotation_Contents.UpperBound = -1;
			EAnnotation_Contents.EType = this.EObject;
			EAnnotation.EStructuralFeatures.Add(EAnnotation_Contents);
			EAnnotation_References = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EAnnotation_References.Name = "references";
			EAnnotation_References.LowerBound = 0;
			EAnnotation_References.UpperBound = -1;
			EAnnotation_References.EType = this.EObject;
			EAnnotation.EStructuralFeatures.Add(EAnnotation_References);
			EClass_Abstract = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EClass_Abstract.Name = "abstract";
			EClass_Abstract.LowerBound = 0;
			EClass_Abstract.UpperBound = 1;
			EClass_Abstract.EType = this.EBoolean;
			EClass.EStructuralFeatures.Add(EClass_Abstract);
			EClass_Interface = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EClass_Interface.Name = "interface";
			EClass_Interface.LowerBound = 0;
			EClass_Interface.UpperBound = 1;
			EClass_Interface.EType = this.EBoolean;
			EClass.EStructuralFeatures.Add(EClass_Interface);
			EClass_ESuperTypes = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EClass_ESuperTypes.Name = "eSuperTypes";
			EClass_ESuperTypes.LowerBound = 0;
			EClass_ESuperTypes.UpperBound = -1;
			EClass_ESuperTypes.EType = this.EClass;
			EClass.EStructuralFeatures.Add(EClass_ESuperTypes);
			EClass_EOperations = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EClass_EOperations.Name = "eOperations";
			EClass_EOperations.LowerBound = 0;
			EClass_EOperations.UpperBound = -1;
			EClass_EOperations.EType = this.EOperation;
			EClass.EStructuralFeatures.Add(EClass_EOperations);
			EClass_EAllAttributes = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EClass_EAllAttributes.Name = "eAllAttributes";
			EClass_EAllAttributes.LowerBound = 0;
			EClass_EAllAttributes.UpperBound = -1;
			EClass_EAllAttributes.EType = this.EAttribute;
			EClass.EStructuralFeatures.Add(EClass_EAllAttributes);
			EClass_EAllReferences = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EClass_EAllReferences.Name = "eAllReferences";
			EClass_EAllReferences.LowerBound = 0;
			EClass_EAllReferences.UpperBound = -1;
			EClass_EAllReferences.EType = this.EReference;
			EClass.EStructuralFeatures.Add(EClass_EAllReferences);
			EClass_EReferences = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EClass_EReferences.Name = "eReferences";
			EClass_EReferences.LowerBound = 0;
			EClass_EReferences.UpperBound = -1;
			EClass_EReferences.EType = this.EReference;
			EClass.EStructuralFeatures.Add(EClass_EReferences);
			EClass_EAttributes = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EClass_EAttributes.Name = "eAttributes";
			EClass_EAttributes.LowerBound = 0;
			EClass_EAttributes.UpperBound = -1;
			EClass_EAttributes.EType = this.EAttribute;
			EClass.EStructuralFeatures.Add(EClass_EAttributes);
			EClass_EAllContainments = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EClass_EAllContainments.Name = "eAllContainments";
			EClass_EAllContainments.LowerBound = 0;
			EClass_EAllContainments.UpperBound = -1;
			EClass_EAllContainments.EType = this.EReference;
			EClass.EStructuralFeatures.Add(EClass_EAllContainments);
			EClass_EAllOperations = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EClass_EAllOperations.Name = "eAllOperations";
			EClass_EAllOperations.LowerBound = 0;
			EClass_EAllOperations.UpperBound = -1;
			EClass_EAllOperations.EType = this.EOperation;
			EClass.EStructuralFeatures.Add(EClass_EAllOperations);
			EClass_EAllStructuralFeatures = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EClass_EAllStructuralFeatures.Name = "eAllStructuralFeatures";
			EClass_EAllStructuralFeatures.LowerBound = 0;
			EClass_EAllStructuralFeatures.UpperBound = -1;
			EClass_EAllStructuralFeatures.EType = this.EStructuralFeature;
			EClass.EStructuralFeatures.Add(EClass_EAllStructuralFeatures);
			EClass_EAllSuperTypes = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EClass_EAllSuperTypes.Name = "eAllSuperTypes";
			EClass_EAllSuperTypes.LowerBound = 0;
			EClass_EAllSuperTypes.UpperBound = -1;
			EClass_EAllSuperTypes.EType = this.EClass;
			EClass.EStructuralFeatures.Add(EClass_EAllSuperTypes);
			EClass_EIDAttribute = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EClass_EIDAttribute.Name = "eIDAttribute";
			EClass_EIDAttribute.LowerBound = 0;
			EClass_EIDAttribute.UpperBound = 1;
			EClass_EIDAttribute.EType = this.EAttribute;
			EClass.EStructuralFeatures.Add(EClass_EIDAttribute);
			EClass_EStructuralFeatures = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EClass_EStructuralFeatures.Name = "eStructuralFeatures";
			EClass_EStructuralFeatures.LowerBound = 0;
			EClass_EStructuralFeatures.UpperBound = -1;
			EClass_EStructuralFeatures.EType = this.EStructuralFeature;
			EClass.EStructuralFeatures.Add(EClass_EStructuralFeatures);
			EClass_EGenericSuperTypes = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EClass_EGenericSuperTypes.Name = "eGenericSuperTypes";
			EClass_EGenericSuperTypes.LowerBound = 0;
			EClass_EGenericSuperTypes.UpperBound = -1;
			EClass_EGenericSuperTypes.EType = this.EGenericType;
			EClass.EStructuralFeatures.Add(EClass_EGenericSuperTypes);
			EClass_EAllGenericSuperTypes = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EClass_EAllGenericSuperTypes.Name = "eAllGenericSuperTypes";
			EClass_EAllGenericSuperTypes.LowerBound = 0;
			EClass_EAllGenericSuperTypes.UpperBound = -1;
			EClass_EAllGenericSuperTypes.EType = this.EGenericType;
			EClass.EStructuralFeatures.Add(EClass_EAllGenericSuperTypes);
			EClassifier_InstanceClassName = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EClassifier_InstanceClassName.Name = "instanceClassName";
			EClassifier_InstanceClassName.LowerBound = 0;
			EClassifier_InstanceClassName.UpperBound = 1;
			EClassifier_InstanceClassName.EType = this.EString;
			EClassifier.EStructuralFeatures.Add(EClassifier_InstanceClassName);
			EClassifier_InstanceTypeName = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EClassifier_InstanceTypeName.Name = "instanceTypeName";
			EClassifier_InstanceTypeName.LowerBound = 0;
			EClassifier_InstanceTypeName.UpperBound = 1;
			EClassifier_InstanceTypeName.EType = this.EString;
			EClassifier.EStructuralFeatures.Add(EClassifier_InstanceTypeName);
			EClassifier_EPackage = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EClassifier_EPackage.Name = "ePackage";
			EClassifier_EPackage.LowerBound = 0;
			EClassifier_EPackage.UpperBound = 1;
			EClassifier_EPackage.EType = this.EPackage;
			EClassifier.EStructuralFeatures.Add(EClassifier_EPackage);
			EClassifier_ETypeParameters = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EClassifier_ETypeParameters.Name = "eTypeParameters";
			EClassifier_ETypeParameters.LowerBound = 0;
			EClassifier_ETypeParameters.UpperBound = -1;
			EClassifier_ETypeParameters.EType = this.ETypeParameter;
			EClassifier.EStructuralFeatures.Add(EClassifier_ETypeParameters);
			EClassifier_CPackage = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EClassifier_CPackage.Name = "cPackage";
			EClassifier_CPackage.LowerBound = 0;
			EClassifier_CPackage.UpperBound = 1;
			EClassifier_CPackage.EType = UnityCMF.CCore.CCoreMeta.cINSTANCE.Package.CPackage;
			EClassifier.EStructuralFeatures.Add(EClassifier_CPackage);
			EDataType_Serializable = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EDataType_Serializable.Name = "serializable";
			EDataType_Serializable.LowerBound = 0;
			EDataType_Serializable.UpperBound = 1;
			EDataType_Serializable.EType = this.EBoolean;
			EDataType.EStructuralFeatures.Add(EDataType_Serializable);
			EEnum_ELiterals = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EEnum_ELiterals.Name = "eLiterals";
			EEnum_ELiterals.LowerBound = 0;
			EEnum_ELiterals.UpperBound = -1;
			EEnum_ELiterals.EType = this.EEnumLiteral;
			EEnum.EStructuralFeatures.Add(EEnum_ELiterals);
			EEnumLiteral_Value = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EEnumLiteral_Value.Name = "value";
			EEnumLiteral_Value.LowerBound = 0;
			EEnumLiteral_Value.UpperBound = 1;
			EEnumLiteral_Value.EType = this.EInt;
			EEnumLiteral.EStructuralFeatures.Add(EEnumLiteral_Value);
			EEnumLiteral_Literal = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EEnumLiteral_Literal.Name = "literal";
			EEnumLiteral_Literal.LowerBound = 0;
			EEnumLiteral_Literal.UpperBound = 1;
			EEnumLiteral_Literal.EType = this.EString;
			EEnumLiteral.EStructuralFeatures.Add(EEnumLiteral_Literal);
			EEnumLiteral_EEnum = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EEnumLiteral_EEnum.Name = "eEnum";
			EEnumLiteral_EEnum.LowerBound = 0;
			EEnumLiteral_EEnum.UpperBound = 1;
			EEnumLiteral_EEnum.EType = this.EEnum;
			EEnumLiteral.EStructuralFeatures.Add(EEnumLiteral_EEnum);
			EFactory_EPackage = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EFactory_EPackage.Name = "ePackage";
			EFactory_EPackage.LowerBound = 1;
			EFactory_EPackage.UpperBound = 1;
			EFactory_EPackage.EType = this.EPackage;
			EFactory.EStructuralFeatures.Add(EFactory_EPackage);
			EModelElement_EAnnotations = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EModelElement_EAnnotations.Name = "eAnnotations";
			EModelElement_EAnnotations.LowerBound = 0;
			EModelElement_EAnnotations.UpperBound = -1;
			EModelElement_EAnnotations.EType = this.EAnnotation;
			EModelElement.EStructuralFeatures.Add(EModelElement_EAnnotations);
			ENamedElement_Name = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			ENamedElement_Name.Name = "name";
			ENamedElement_Name.LowerBound = 0;
			ENamedElement_Name.UpperBound = 1;
			ENamedElement_Name.EType = this.EString;
			ENamedElement.EStructuralFeatures.Add(ENamedElement_Name);
			EOperation_EContainingClass = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EOperation_EContainingClass.Name = "eContainingClass";
			EOperation_EContainingClass.LowerBound = 0;
			EOperation_EContainingClass.UpperBound = 1;
			EOperation_EContainingClass.EType = this.EClass;
			EOperation.EStructuralFeatures.Add(EOperation_EContainingClass);
			EOperation_ETypeParameters = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EOperation_ETypeParameters.Name = "eTypeParameters";
			EOperation_ETypeParameters.LowerBound = 0;
			EOperation_ETypeParameters.UpperBound = -1;
			EOperation_ETypeParameters.EType = this.ETypeParameter;
			EOperation.EStructuralFeatures.Add(EOperation_ETypeParameters);
			EOperation_EParameters = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EOperation_EParameters.Name = "eParameters";
			EOperation_EParameters.LowerBound = 0;
			EOperation_EParameters.UpperBound = -1;
			EOperation_EParameters.EType = this.EParameter;
			EOperation.EStructuralFeatures.Add(EOperation_EParameters);
			EOperation_EExceptions = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EOperation_EExceptions.Name = "eExceptions";
			EOperation_EExceptions.LowerBound = 0;
			EOperation_EExceptions.UpperBound = -1;
			EOperation_EExceptions.EType = this.EClassifier;
			EOperation.EStructuralFeatures.Add(EOperation_EExceptions);
			EOperation_EGenericExceptions = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EOperation_EGenericExceptions.Name = "eGenericExceptions";
			EOperation_EGenericExceptions.LowerBound = 0;
			EOperation_EGenericExceptions.UpperBound = -1;
			EOperation_EGenericExceptions.EType = this.EGenericType;
			EOperation.EStructuralFeatures.Add(EOperation_EGenericExceptions);
			EPackage_NsURI = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EPackage_NsURI.Name = "nsURI";
			EPackage_NsURI.LowerBound = 0;
			EPackage_NsURI.UpperBound = 1;
			EPackage_NsURI.EType = this.EString;
			EPackage.EStructuralFeatures.Add(EPackage_NsURI);
			EPackage_NsPrefix = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EPackage_NsPrefix.Name = "nsPrefix";
			EPackage_NsPrefix.LowerBound = 0;
			EPackage_NsPrefix.UpperBound = 1;
			EPackage_NsPrefix.EType = this.EString;
			EPackage.EStructuralFeatures.Add(EPackage_NsPrefix);
			EPackage_EFactoryInstance = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EPackage_EFactoryInstance.Name = "eFactoryInstance";
			EPackage_EFactoryInstance.LowerBound = 1;
			EPackage_EFactoryInstance.UpperBound = 1;
			EPackage_EFactoryInstance.EType = this.EFactory;
			EPackage.EStructuralFeatures.Add(EPackage_EFactoryInstance);
			EPackage_EClassifiers = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EPackage_EClassifiers.Name = "eClassifiers";
			EPackage_EClassifiers.LowerBound = 0;
			EPackage_EClassifiers.UpperBound = -1;
			EPackage_EClassifiers.EType = this.EClassifier;
			EPackage.EStructuralFeatures.Add(EPackage_EClassifiers);
			EPackage_ESubpackages = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EPackage_ESubpackages.Name = "eSubpackages";
			EPackage_ESubpackages.LowerBound = 0;
			EPackage_ESubpackages.UpperBound = -1;
			EPackage_ESubpackages.EType = this.EPackage;
			EPackage.EStructuralFeatures.Add(EPackage_ESubpackages);
			EPackage_ESuperPackage = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EPackage_ESuperPackage.Name = "eSuperPackage";
			EPackage_ESuperPackage.LowerBound = 0;
			EPackage_ESuperPackage.UpperBound = 1;
			EPackage_ESuperPackage.EType = this.EPackage;
			EPackage.EStructuralFeatures.Add(EPackage_ESuperPackage);
			EParameter_EOperation = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EParameter_EOperation.Name = "eOperation";
			EParameter_EOperation.LowerBound = 0;
			EParameter_EOperation.UpperBound = 1;
			EParameter_EOperation.EType = this.EOperation;
			EParameter.EStructuralFeatures.Add(EParameter_EOperation);
			EReference_Containment = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EReference_Containment.Name = "containment";
			EReference_Containment.LowerBound = 0;
			EReference_Containment.UpperBound = 1;
			EReference_Containment.EType = this.EBoolean;
			EReference.EStructuralFeatures.Add(EReference_Containment);
			EReference_Container = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EReference_Container.Name = "container";
			EReference_Container.LowerBound = 0;
			EReference_Container.UpperBound = 1;
			EReference_Container.EType = this.EBoolean;
			EReference.EStructuralFeatures.Add(EReference_Container);
			EReference_ResolveProxies = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EReference_ResolveProxies.Name = "resolveProxies";
			EReference_ResolveProxies.LowerBound = 0;
			EReference_ResolveProxies.UpperBound = 1;
			EReference_ResolveProxies.EType = this.EBoolean;
			EReference.EStructuralFeatures.Add(EReference_ResolveProxies);
			EReference_EOpposite = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EReference_EOpposite.Name = "eOpposite";
			EReference_EOpposite.LowerBound = 0;
			EReference_EOpposite.UpperBound = 1;
			EReference_EOpposite.EType = this.EReference;
			EReference.EStructuralFeatures.Add(EReference_EOpposite);
			EReference_EReferenceType = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EReference_EReferenceType.Name = "eReferenceType";
			EReference_EReferenceType.LowerBound = 1;
			EReference_EReferenceType.UpperBound = 1;
			EReference_EReferenceType.EType = this.EClass;
			EReference.EStructuralFeatures.Add(EReference_EReferenceType);
			EReference_EKeys = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EReference_EKeys.Name = "eKeys";
			EReference_EKeys.LowerBound = 0;
			EReference_EKeys.UpperBound = -1;
			EReference_EKeys.EType = this.EAttribute;
			EReference.EStructuralFeatures.Add(EReference_EKeys);
			EStructuralFeature_Changeable = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EStructuralFeature_Changeable.Name = "changeable";
			EStructuralFeature_Changeable.LowerBound = 0;
			EStructuralFeature_Changeable.UpperBound = 1;
			EStructuralFeature_Changeable.EType = this.EBoolean;
			EStructuralFeature.EStructuralFeatures.Add(EStructuralFeature_Changeable);
			EStructuralFeature_Volatile = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EStructuralFeature_Volatile.Name = "volatile";
			EStructuralFeature_Volatile.LowerBound = 0;
			EStructuralFeature_Volatile.UpperBound = 1;
			EStructuralFeature_Volatile.EType = this.EBoolean;
			EStructuralFeature.EStructuralFeatures.Add(EStructuralFeature_Volatile);
			EStructuralFeature_Transient = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EStructuralFeature_Transient.Name = "transient";
			EStructuralFeature_Transient.LowerBound = 0;
			EStructuralFeature_Transient.UpperBound = 1;
			EStructuralFeature_Transient.EType = this.EBoolean;
			EStructuralFeature.EStructuralFeatures.Add(EStructuralFeature_Transient);
			EStructuralFeature_DefaultValueLiteral = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EStructuralFeature_DefaultValueLiteral.Name = "defaultValueLiteral";
			EStructuralFeature_DefaultValueLiteral.LowerBound = 0;
			EStructuralFeature_DefaultValueLiteral.UpperBound = 1;
			EStructuralFeature_DefaultValueLiteral.EType = this.EString;
			EStructuralFeature.EStructuralFeatures.Add(EStructuralFeature_DefaultValueLiteral);
			EStructuralFeature_Unsettable = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EStructuralFeature_Unsettable.Name = "unsettable";
			EStructuralFeature_Unsettable.LowerBound = 0;
			EStructuralFeature_Unsettable.UpperBound = 1;
			EStructuralFeature_Unsettable.EType = this.EBoolean;
			EStructuralFeature.EStructuralFeatures.Add(EStructuralFeature_Unsettable);
			EStructuralFeature_Derived = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EStructuralFeature_Derived.Name = "derived";
			EStructuralFeature_Derived.LowerBound = 0;
			EStructuralFeature_Derived.UpperBound = 1;
			EStructuralFeature_Derived.EType = this.EBoolean;
			EStructuralFeature.EStructuralFeatures.Add(EStructuralFeature_Derived);
			EStructuralFeature_EContainingClass = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EStructuralFeature_EContainingClass.Name = "eContainingClass";
			EStructuralFeature_EContainingClass.LowerBound = 0;
			EStructuralFeature_EContainingClass.UpperBound = 1;
			EStructuralFeature_EContainingClass.EType = this.EClass;
			EStructuralFeature.EStructuralFeatures.Add(EStructuralFeature_EContainingClass);
			ETypedElement_Ordered = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			ETypedElement_Ordered.Name = "ordered";
			ETypedElement_Ordered.LowerBound = 0;
			ETypedElement_Ordered.UpperBound = 1;
			ETypedElement_Ordered.EType = this.EBoolean;
			ETypedElement.EStructuralFeatures.Add(ETypedElement_Ordered);
			ETypedElement_Unique = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			ETypedElement_Unique.Name = "unique";
			ETypedElement_Unique.LowerBound = 0;
			ETypedElement_Unique.UpperBound = 1;
			ETypedElement_Unique.EType = this.EBoolean;
			ETypedElement.EStructuralFeatures.Add(ETypedElement_Unique);
			ETypedElement_LowerBound = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			ETypedElement_LowerBound.Name = "lowerBound";
			ETypedElement_LowerBound.LowerBound = 0;
			ETypedElement_LowerBound.UpperBound = 1;
			ETypedElement_LowerBound.EType = this.EInt;
			ETypedElement.EStructuralFeatures.Add(ETypedElement_LowerBound);
			ETypedElement_UpperBound = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			ETypedElement_UpperBound.Name = "upperBound";
			ETypedElement_UpperBound.LowerBound = 0;
			ETypedElement_UpperBound.UpperBound = 1;
			ETypedElement_UpperBound.EType = this.EInt;
			ETypedElement.EStructuralFeatures.Add(ETypedElement_UpperBound);
			ETypedElement_Many = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			ETypedElement_Many.Name = "many";
			ETypedElement_Many.LowerBound = 0;
			ETypedElement_Many.UpperBound = 1;
			ETypedElement_Many.EType = this.EBoolean;
			ETypedElement.EStructuralFeatures.Add(ETypedElement_Many);
			ETypedElement_Required = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			ETypedElement_Required.Name = "required";
			ETypedElement_Required.LowerBound = 0;
			ETypedElement_Required.UpperBound = 1;
			ETypedElement_Required.EType = this.EBoolean;
			ETypedElement.EStructuralFeatures.Add(ETypedElement_Required);
			ETypedElement_EType = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			ETypedElement_EType.Name = "eType";
			ETypedElement_EType.LowerBound = 0;
			ETypedElement_EType.UpperBound = 1;
			ETypedElement_EType.EType = this.EClassifier;
			ETypedElement.EStructuralFeatures.Add(ETypedElement_EType);
			ETypedElement_EGenericType = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			ETypedElement_EGenericType.Name = "eGenericType";
			ETypedElement_EGenericType.LowerBound = 0;
			ETypedElement_EGenericType.UpperBound = 1;
			ETypedElement_EGenericType.EType = this.EGenericType;
			ETypedElement.EStructuralFeatures.Add(ETypedElement_EGenericType);
			EStringToStringMapEntry_Key = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EStringToStringMapEntry_Key.Name = "key";
			EStringToStringMapEntry_Key.LowerBound = 0;
			EStringToStringMapEntry_Key.UpperBound = 1;
			EStringToStringMapEntry_Key.EType = this.EString;
			EStringToStringMapEntry.EStructuralFeatures.Add(EStringToStringMapEntry_Key);
			EStringToStringMapEntry_Value = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EStringToStringMapEntry_Value.Name = "value";
			EStringToStringMapEntry_Value.LowerBound = 0;
			EStringToStringMapEntry_Value.UpperBound = 1;
			EStringToStringMapEntry_Value.EType = this.EString;
			EStringToStringMapEntry.EStructuralFeatures.Add(EStringToStringMapEntry_Value);
			EGenericType_EUpperBound = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EGenericType_EUpperBound.Name = "eUpperBound";
			EGenericType_EUpperBound.LowerBound = 0;
			EGenericType_EUpperBound.UpperBound = 1;
			EGenericType_EUpperBound.EType = this.EGenericType;
			EGenericType.EStructuralFeatures.Add(EGenericType_EUpperBound);
			EGenericType_ETypeArguments = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EGenericType_ETypeArguments.Name = "eTypeArguments";
			EGenericType_ETypeArguments.LowerBound = 0;
			EGenericType_ETypeArguments.UpperBound = -1;
			EGenericType_ETypeArguments.EType = this.EGenericType;
			EGenericType.EStructuralFeatures.Add(EGenericType_ETypeArguments);
			EGenericType_ERawType = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EGenericType_ERawType.Name = "eRawType";
			EGenericType_ERawType.LowerBound = 1;
			EGenericType_ERawType.UpperBound = 1;
			EGenericType_ERawType.EType = this.EClassifier;
			EGenericType.EStructuralFeatures.Add(EGenericType_ERawType);
			EGenericType_ELowerBound = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EGenericType_ELowerBound.Name = "eLowerBound";
			EGenericType_ELowerBound.LowerBound = 0;
			EGenericType_ELowerBound.UpperBound = 1;
			EGenericType_ELowerBound.EType = this.EGenericType;
			EGenericType.EStructuralFeatures.Add(EGenericType_ELowerBound);
			EGenericType_ETypeParameter = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EGenericType_ETypeParameter.Name = "eTypeParameter";
			EGenericType_ETypeParameter.LowerBound = 0;
			EGenericType_ETypeParameter.UpperBound = 1;
			EGenericType_ETypeParameter.EType = this.ETypeParameter;
			EGenericType.EStructuralFeatures.Add(EGenericType_ETypeParameter);
			EGenericType_EClassifier = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			EGenericType_EClassifier.Name = "eClassifier";
			EGenericType_EClassifier.LowerBound = 0;
			EGenericType_EClassifier.UpperBound = 1;
			EGenericType_EClassifier.EType = this.EClassifier;
			EGenericType.EStructuralFeatures.Add(EGenericType_EClassifier);
			ETypeParameter_EBounds = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			ETypeParameter_EBounds.Name = "eBounds";
			ETypeParameter_EBounds.LowerBound = 0;
			ETypeParameter_EBounds.UpperBound = -1;
			ETypeParameter_EBounds.EType = this.EGenericType;
			ETypeParameter.EStructuralFeatures.Add(ETypeParameter_EBounds);
		}
		
		public EClass EAttribute { get; private set;}
		public EStructuralFeature EAttribute_ID  { get; private set;}
		public EStructuralFeature EAttribute_EAttributeType  { get; private set;}
		public EClass EAnnotation { get; private set;}
		public EStructuralFeature EAnnotation_Source  { get; private set;}
		public EStructuralFeature EAnnotation_Details  { get; private set;}
		public EStructuralFeature EAnnotation_EModelElement  { get; private set;}
		public EStructuralFeature EAnnotation_Contents  { get; private set;}
		public EStructuralFeature EAnnotation_References  { get; private set;}
		public EClass EClass { get; private set;}
		public EStructuralFeature EClass_Abstract  { get; private set;}
		public EStructuralFeature EClass_Interface  { get; private set;}
		public EStructuralFeature EClass_ESuperTypes  { get; private set;}
		public EStructuralFeature EClass_EOperations  { get; private set;}
		public EStructuralFeature EClass_EAllAttributes  { get; private set;}
		public EStructuralFeature EClass_EAllReferences  { get; private set;}
		public EStructuralFeature EClass_EReferences  { get; private set;}
		public EStructuralFeature EClass_EAttributes  { get; private set;}
		public EStructuralFeature EClass_EAllContainments  { get; private set;}
		public EStructuralFeature EClass_EAllOperations  { get; private set;}
		public EStructuralFeature EClass_EAllStructuralFeatures  { get; private set;}
		public EStructuralFeature EClass_EAllSuperTypes  { get; private set;}
		public EStructuralFeature EClass_EIDAttribute  { get; private set;}
		public EStructuralFeature EClass_EStructuralFeatures  { get; private set;}
		public EStructuralFeature EClass_EGenericSuperTypes  { get; private set;}
		public EStructuralFeature EClass_EAllGenericSuperTypes  { get; private set;}
		public EClass EClassifier { get; private set;}
		public EStructuralFeature EClassifier_InstanceClassName  { get; private set;}
		public EStructuralFeature EClassifier_InstanceTypeName  { get; private set;}
		public EStructuralFeature EClassifier_EPackage  { get; private set;}
		public EStructuralFeature EClassifier_ETypeParameters  { get; private set;}
		public EStructuralFeature EClassifier_CPackage  { get; private set;}
		public EClass EDataType { get; private set;}
		public EStructuralFeature EDataType_Serializable  { get; private set;}
		public EClass EEnum { get; private set;}
		public EStructuralFeature EEnum_ELiterals  { get; private set;}
		public EClass EEnumLiteral { get; private set;}
		public EStructuralFeature EEnumLiteral_Value  { get; private set;}
		public EStructuralFeature EEnumLiteral_Literal  { get; private set;}
		public EStructuralFeature EEnumLiteral_EEnum  { get; private set;}
		public EClass EFactory { get; private set;}
		public EStructuralFeature EFactory_EPackage  { get; private set;}
		public EClass EModelElement { get; private set;}
		public EStructuralFeature EModelElement_EAnnotations  { get; private set;}
		public EClass ENamedElement { get; private set;}
		public EStructuralFeature ENamedElement_Name  { get; private set;}
		public EClass EObject { get; private set;}
		public EClass EOperation { get; private set;}
		public EStructuralFeature EOperation_EContainingClass  { get; private set;}
		public EStructuralFeature EOperation_ETypeParameters  { get; private set;}
		public EStructuralFeature EOperation_EParameters  { get; private set;}
		public EStructuralFeature EOperation_EExceptions  { get; private set;}
		public EStructuralFeature EOperation_EGenericExceptions  { get; private set;}
		public EClass EPackage { get; private set;}
		public EStructuralFeature EPackage_NsURI  { get; private set;}
		public EStructuralFeature EPackage_NsPrefix  { get; private set;}
		public EStructuralFeature EPackage_EFactoryInstance  { get; private set;}
		public EStructuralFeature EPackage_EClassifiers  { get; private set;}
		public EStructuralFeature EPackage_ESubpackages  { get; private set;}
		public EStructuralFeature EPackage_ESuperPackage  { get; private set;}
		public EClass EParameter { get; private set;}
		public EStructuralFeature EParameter_EOperation  { get; private set;}
		public EClass EReference { get; private set;}
		public EStructuralFeature EReference_Containment  { get; private set;}
		public EStructuralFeature EReference_Container  { get; private set;}
		public EStructuralFeature EReference_ResolveProxies  { get; private set;}
		public EStructuralFeature EReference_EOpposite  { get; private set;}
		public EStructuralFeature EReference_EReferenceType  { get; private set;}
		public EStructuralFeature EReference_EKeys  { get; private set;}
		public EClass EStructuralFeature { get; private set;}
		public EStructuralFeature EStructuralFeature_Changeable  { get; private set;}
		public EStructuralFeature EStructuralFeature_Volatile  { get; private set;}
		public EStructuralFeature EStructuralFeature_Transient  { get; private set;}
		public EStructuralFeature EStructuralFeature_DefaultValueLiteral  { get; private set;}
		public EStructuralFeature EStructuralFeature_Unsettable  { get; private set;}
		public EStructuralFeature EStructuralFeature_Derived  { get; private set;}
		public EStructuralFeature EStructuralFeature_EContainingClass  { get; private set;}
		public EClass ETypedElement { get; private set;}
		public EStructuralFeature ETypedElement_Ordered  { get; private set;}
		public EStructuralFeature ETypedElement_Unique  { get; private set;}
		public EStructuralFeature ETypedElement_LowerBound  { get; private set;}
		public EStructuralFeature ETypedElement_UpperBound  { get; private set;}
		public EStructuralFeature ETypedElement_Many  { get; private set;}
		public EStructuralFeature ETypedElement_Required  { get; private set;}
		public EStructuralFeature ETypedElement_EType  { get; private set;}
		public EStructuralFeature ETypedElement_EGenericType  { get; private set;}
		public EClass EStringToStringMapEntry { get; private set;}
		public EStructuralFeature EStringToStringMapEntry_Key  { get; private set;}
		public EStructuralFeature EStringToStringMapEntry_Value  { get; private set;}
		public EClass EGenericType { get; private set;}
		public EStructuralFeature EGenericType_EUpperBound  { get; private set;}
		public EStructuralFeature EGenericType_ETypeArguments  { get; private set;}
		public EStructuralFeature EGenericType_ERawType  { get; private set;}
		public EStructuralFeature EGenericType_ELowerBound  { get; private set;}
		public EStructuralFeature EGenericType_ETypeParameter  { get; private set;}
		public EStructuralFeature EGenericType_EClassifier  { get; private set;}
		public EClass ETypeParameter { get; private set;}
		public EStructuralFeature ETypeParameter_EBounds  { get; private set;}
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
		
		public EClassifier getClassifier(string name) {
			switch(name) {
				case "EAttribute": return ECoreMeta.cINSTANCE.Package.EAttribute;
				case "EAnnotation": return ECoreMeta.cINSTANCE.Package.EAnnotation;
				case "EClass": return ECoreMeta.cINSTANCE.Package.EClass;
				case "EClassifier": return ECoreMeta.cINSTANCE.Package.EClassifier;
				case "EDataType": return ECoreMeta.cINSTANCE.Package.EDataType;
				case "EEnum": return ECoreMeta.cINSTANCE.Package.EEnum;
				case "EEnumLiteral": return ECoreMeta.cINSTANCE.Package.EEnumLiteral;
				case "EFactory": return ECoreMeta.cINSTANCE.Package.EFactory;
				case "EModelElement": return ECoreMeta.cINSTANCE.Package.EModelElement;
				case "ENamedElement": return ECoreMeta.cINSTANCE.Package.ENamedElement;
				case "EObject": return ECoreMeta.cINSTANCE.Package.EObject;
				case "EOperation": return ECoreMeta.cINSTANCE.Package.EOperation;
				case "EPackage": return ECoreMeta.cINSTANCE.Package.EPackage;
				case "EParameter": return ECoreMeta.cINSTANCE.Package.EParameter;
				case "EReference": return ECoreMeta.cINSTANCE.Package.EReference;
				case "EStructuralFeature": return ECoreMeta.cINSTANCE.Package.EStructuralFeature;
				case "ETypedElement": return ECoreMeta.cINSTANCE.Package.ETypedElement;
				case "EStringToStringMapEntry": return ECoreMeta.cINSTANCE.Package.EStringToStringMapEntry;
				case "EGenericType": return ECoreMeta.cINSTANCE.Package.EGenericType;
				case "ETypeParameter": return ECoreMeta.cINSTANCE.Package.ETypeParameter;
				case "EBigDecimal": return ECoreMeta.cINSTANCE.Package.EBigDecimal;
				case "EBigInteger": return ECoreMeta.cINSTANCE.Package.EBigInteger;
				case "EBoolean": return ECoreMeta.cINSTANCE.Package.EBoolean;
				case "EBooleanObject": return ECoreMeta.cINSTANCE.Package.EBooleanObject;
				case "EByte": return ECoreMeta.cINSTANCE.Package.EByte;
				case "EByteArray": return ECoreMeta.cINSTANCE.Package.EByteArray;
				case "EByteObject": return ECoreMeta.cINSTANCE.Package.EByteObject;
				case "EChar": return ECoreMeta.cINSTANCE.Package.EChar;
				case "ECharacterObject": return ECoreMeta.cINSTANCE.Package.ECharacterObject;
				case "EDate": return ECoreMeta.cINSTANCE.Package.EDate;
				case "EDiagnosticChain": return ECoreMeta.cINSTANCE.Package.EDiagnosticChain;
				case "EDouble": return ECoreMeta.cINSTANCE.Package.EDouble;
				case "EDoubleObject": return ECoreMeta.cINSTANCE.Package.EDoubleObject;
				case "EEList": return ECoreMeta.cINSTANCE.Package.EEList;
				case "EEnumerator": return ECoreMeta.cINSTANCE.Package.EEnumerator;
				case "EFeatureMap": return ECoreMeta.cINSTANCE.Package.EFeatureMap;
				case "EFeatureMapEntry": return ECoreMeta.cINSTANCE.Package.EFeatureMapEntry;
				case "EFloat": return ECoreMeta.cINSTANCE.Package.EFloat;
				case "EFloatObject": return ECoreMeta.cINSTANCE.Package.EFloatObject;
				case "EInt": return ECoreMeta.cINSTANCE.Package.EInt;
				case "EIntegerObject": return ECoreMeta.cINSTANCE.Package.EIntegerObject;
				case "EJavaClass": return ECoreMeta.cINSTANCE.Package.EJavaClass;
				case "EJavaObject": return ECoreMeta.cINSTANCE.Package.EJavaObject;
				case "ELong": return ECoreMeta.cINSTANCE.Package.ELong;
				case "ELongObject": return ECoreMeta.cINSTANCE.Package.ELongObject;
				case "EMap": return ECoreMeta.cINSTANCE.Package.EMap;
				case "EResource": return ECoreMeta.cINSTANCE.Package.EResource;
				case "EResourceSet": return ECoreMeta.cINSTANCE.Package.EResourceSet;
				case "EShort": return ECoreMeta.cINSTANCE.Package.EShort;
				case "EShortObject": return ECoreMeta.cINSTANCE.Package.EShortObject;
				case "EString": return ECoreMeta.cINSTANCE.Package.EString;
				case "ETreeIterator": return ECoreMeta.cINSTANCE.Package.ETreeIterator;
				case "EInvocationTargetException": return ECoreMeta.cINSTANCE.Package.EInvocationTargetException;
				default: return null;	
			}	
		}
	}
	public interface ECoreFactory : CFactory {
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
		public CPackage PackageInstance {
			get {
				return ECoreMeta.cINSTANCE.Package;
			}	
		}
		
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
		
		public CObject create(EClass eClass) {
			switch(eClass.Name) {
				case "EAttribute": return new EAttributeImpl(eClass);
				case "EAnnotation": return new EAnnotationImpl(eClass);
				case "EClass": return new EClassImpl(eClass);
				case "EClassifier": return new EClassifierImpl(eClass);
				case "EDataType": return new EDataTypeImpl(eClass);
				case "EEnum": return new EEnumImpl(eClass);
				case "EEnumLiteral": return new EEnumLiteralImpl(eClass);
				case "EFactory": return new EFactoryImpl(eClass);
				case "EModelElement": return new EModelElementImpl(eClass);
				case "ENamedElement": return new ENamedElementImpl(eClass);
				case "EObject": return new EObjectImpl(eClass);
				case "EOperation": return new EOperationImpl(eClass);
				case "EPackage": return new EPackageImpl(eClass);
				case "EParameter": return new EParameterImpl(eClass);
				case "EReference": return new EReferenceImpl(eClass);
				case "EStructuralFeature": return new EStructuralFeatureImpl(eClass);
				case "ETypedElement": return new ETypedElementImpl(eClass);
				case "EStringToStringMapEntry": return new EStringToStringMapEntryImpl(eClass);
				case "EGenericType": return new EGenericTypeImpl(eClass);
				case "ETypeParameter": return new ETypeParameterImpl(eClass);
				default: return null;	
			}	
		}
	}
	
} // UnityCMF.ECore
