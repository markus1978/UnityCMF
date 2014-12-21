/**
 */
package com.cubemonstergames.unitycmf.ccore.impl;

import com.cubemonstergames.unitycmf.ccore.C2DFieldElement;
import com.cubemonstergames.unitycmf.ccore.CcoreFactory;
import com.cubemonstergames.unitycmf.ccore.CcorePackage;
import com.cubemonstergames.unitycmf.ccore.Direction;

import org.eclipse.emf.ecore.EAttribute;
import org.eclipse.emf.ecore.EClass;
import org.eclipse.emf.ecore.EDataType;
import org.eclipse.emf.ecore.EEnum;
import org.eclipse.emf.ecore.EOperation;
import org.eclipse.emf.ecore.EPackage;

import org.eclipse.emf.ecore.impl.EPackageImpl;

/**
 * <!-- begin-user-doc -->
 * An implementation of the model <b>Package</b>.
 * <!-- end-user-doc -->
 * @generated
 */
public class CcorePackageImpl extends EPackageImpl implements CcorePackage {
	/**
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @generated
	 */
	private EClass c2DFieldElementEClass = null;

	/**
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @generated
	 */
	private EEnum directionEEnum = null;

	/**
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @generated
	 */
	private EDataType cActionEDataType = null;

	/**
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @generated
	 */
	private EDataType cPackageEDataType = null;

	/**
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @generated
	 */
	private EDataType cFactoryEDataType = null;

	/**
	 * Creates an instance of the model <b>Package</b>, registered with
	 * {@link org.eclipse.emf.ecore.EPackage.Registry EPackage.Registry} by the package
	 * package URI value.
	 * <p>Note: the correct way to create the package is via the static
	 * factory method {@link #init init()}, which also performs
	 * initialization of the package, or returns the registered package,
	 * if one already exists.
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @see org.eclipse.emf.ecore.EPackage.Registry
	 * @see com.cubemonstergames.unitycmf.ccore.CcorePackage#eNS_URI
	 * @see #init()
	 * @generated
	 */
	private CcorePackageImpl() {
		super(eNS_URI, CcoreFactory.eINSTANCE);
	}

	/**
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @generated
	 */
	private static boolean isInited = false;

	/**
	 * Creates, registers, and initializes the <b>Package</b> for this model, and for any others upon which it depends.
	 * 
	 * <p>This method is used to initialize {@link CcorePackage#eINSTANCE} when that field is accessed.
	 * Clients should not invoke it directly. Instead, they should simply access that field to obtain the package.
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @see #eNS_URI
	 * @see #createPackageContents()
	 * @see #initializePackageContents()
	 * @generated
	 */
	public static CcorePackage init() {
		if (isInited) return (CcorePackage)EPackage.Registry.INSTANCE.getEPackage(CcorePackage.eNS_URI);

		// Obtain or create and register package
		CcorePackageImpl theCcorePackage = (CcorePackageImpl)(EPackage.Registry.INSTANCE.get(eNS_URI) instanceof CcorePackageImpl ? EPackage.Registry.INSTANCE.get(eNS_URI) : new CcorePackageImpl());

		isInited = true;

		// Create package meta-data objects
		theCcorePackage.createPackageContents();

		// Initialize created meta-data
		theCcorePackage.initializePackageContents();

		// Mark meta-data to indicate it can't be changed
		theCcorePackage.freeze();

  
		// Update the registry and return the package
		EPackage.Registry.INSTANCE.put(CcorePackage.eNS_URI, theCcorePackage);
		return theCcorePackage;
	}

	/**
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @generated
	 */
	public EClass getC2DFieldElement() {
		return c2DFieldElementEClass;
	}

	/**
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @generated
	 */
	public EAttribute getC2DFieldElement_X() {
		return (EAttribute)c2DFieldElementEClass.getEStructuralFeatures().get(0);
	}

	/**
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @generated
	 */
	public EAttribute getC2DFieldElement_Y() {
		return (EAttribute)c2DFieldElementEClass.getEStructuralFeatures().get(1);
	}

	/**
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @generated
	 */
	public EOperation getC2DFieldElement__Neighbor__C2DFieldElement() {
		return c2DFieldElementEClass.getEOperations().get(0);
	}

	/**
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @generated
	 */
	public EEnum getDirection() {
		return directionEEnum;
	}

	/**
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @generated
	 */
	public EDataType getCAction() {
		return cActionEDataType;
	}

	/**
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @generated
	 */
	public EDataType getCPackage() {
		return cPackageEDataType;
	}

	/**
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @generated
	 */
	public EDataType getCFactory() {
		return cFactoryEDataType;
	}

	/**
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @generated
	 */
	public CcoreFactory getCcoreFactory() {
		return (CcoreFactory)getEFactoryInstance();
	}

	/**
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @generated
	 */
	private boolean isCreated = false;

	/**
	 * Creates the meta-model objects for the package.  This method is
	 * guarded to have no affect on any invocation but its first.
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @generated
	 */
	public void createPackageContents() {
		if (isCreated) return;
		isCreated = true;

		// Create classes and their features
		c2DFieldElementEClass = createEClass(C2D_FIELD_ELEMENT);
		createEAttribute(c2DFieldElementEClass, C2D_FIELD_ELEMENT__X);
		createEAttribute(c2DFieldElementEClass, C2D_FIELD_ELEMENT__Y);
		createEOperation(c2DFieldElementEClass, C2D_FIELD_ELEMENT___NEIGHBOR__C2DFIELDELEMENT);

		// Create enums
		directionEEnum = createEEnum(DIRECTION);

		// Create data types
		cActionEDataType = createEDataType(CACTION);
		cPackageEDataType = createEDataType(CPACKAGE);
		cFactoryEDataType = createEDataType(CFACTORY);
	}

	/**
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @generated
	 */
	private boolean isInitialized = false;

	/**
	 * Complete the initialization of the package and its meta-model.  This
	 * method is guarded to have no affect on any invocation but its first.
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @generated
	 */
	public void initializePackageContents() {
		if (isInitialized) return;
		isInitialized = true;

		// Initialize package
		setName(eNAME);
		setNsPrefix(eNS_PREFIX);
		setNsURI(eNS_URI);

		// Create type parameters

		// Set bounds for type parameters

		// Add supertypes to classes

		// Initialize classes, features, and operations; add parameters
		initEClass(c2DFieldElementEClass, C2DFieldElement.class, "C2DFieldElement", IS_ABSTRACT, !IS_INTERFACE, IS_GENERATED_INSTANCE_CLASS);
		initEAttribute(getC2DFieldElement_X(), ecorePackage.getEInt(), "x", "-1", 0, 1, C2DFieldElement.class, !IS_TRANSIENT, !IS_VOLATILE, IS_CHANGEABLE, !IS_UNSETTABLE, !IS_ID, IS_UNIQUE, !IS_DERIVED, IS_ORDERED);
		initEAttribute(getC2DFieldElement_Y(), ecorePackage.getEInt(), "y", "-1", 0, 1, C2DFieldElement.class, !IS_TRANSIENT, !IS_VOLATILE, IS_CHANGEABLE, !IS_UNSETTABLE, !IS_ID, IS_UNIQUE, !IS_DERIVED, IS_ORDERED);

		EOperation op = initEOperation(getC2DFieldElement__Neighbor__C2DFieldElement(), this.getDirection(), "Neighbor", 0, 1, IS_UNIQUE, IS_ORDERED);
		addEParameter(op, this.getC2DFieldElement(), "other", 0, 1, IS_UNIQUE, IS_ORDERED);

		// Initialize enums and add enum literals
		initEEnum(directionEEnum, Direction.class, "Direction");
		addEEnumLiteral(directionEEnum, Direction.NONE);
		addEEnumLiteral(directionEEnum, Direction.LEFT);
		addEEnumLiteral(directionEEnum, Direction.TOP);
		addEEnumLiteral(directionEEnum, Direction.RIGHT);
		addEEnumLiteral(directionEEnum, Direction.BOTTOM);
		addEEnumLiteral(directionEEnum, Direction.START);

		// Initialize data types
		initEDataType(cActionEDataType, Object.class, "CAction", IS_SERIALIZABLE, !IS_GENERATED_INSTANCE_CLASS);
		initEDataType(cPackageEDataType, Object.class, "CPackage", IS_SERIALIZABLE, !IS_GENERATED_INSTANCE_CLASS);
		initEDataType(cFactoryEDataType, Object.class, "CFactory", IS_SERIALIZABLE, !IS_GENERATED_INSTANCE_CLASS);

		// Create resource
		createResource(eNS_URI);

		// Create annotations
		// http://com.cubemonstergames/UnityCMF
		createUnityCMFAnnotations();
	}

	/**
	 * Initializes the annotations for <b>http://com.cubemonstergames/UnityCMF</b>.
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @generated
	 */
	protected void createUnityCMFAnnotations() {
		String source = "http://com.cubemonstergames/UnityCMF";		
		addAnnotation
		  (cActionEDataType, 
		   source, 
		   new String[] {
			 "CInstanceClass", "UnityCMF.CCore.CAction"
		   });		
		addAnnotation
		  (cPackageEDataType, 
		   source, 
		   new String[] {
			 "CInstanceClass", "UnityCMF.CCore.CPackage"
		   });		
		addAnnotation
		  (cFactoryEDataType, 
		   source, 
		   new String[] {
			 "CInstanceClass", "UnityCMF.CCore.CFactory"
		   });
	}

} //CcorePackageImpl
