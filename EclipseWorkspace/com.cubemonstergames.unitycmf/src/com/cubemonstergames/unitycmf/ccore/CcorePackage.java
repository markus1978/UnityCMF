/**
 */
package com.cubemonstergames.unitycmf.ccore;

import org.eclipse.emf.ecore.EAttribute;
import org.eclipse.emf.ecore.EClass;
import org.eclipse.emf.ecore.EDataType;
import org.eclipse.emf.ecore.EEnum;
import org.eclipse.emf.ecore.EOperation;
import org.eclipse.emf.ecore.EPackage;

/**
 * <!-- begin-user-doc -->
 * The <b>Package</b> for the model.
 * It contains accessors for the meta objects to represent
 * <ul>
 *   <li>each class,</li>
 *   <li>each feature of each class,</li>
 *   <li>each operation of each class,</li>
 *   <li>each enum,</li>
 *   <li>and each data type</li>
 * </ul>
 * <!-- end-user-doc -->
 * @see com.cubemonstergames.unitycmf.ccore.CcoreFactory
 * @model kind="package"
 * @generated
 */
public interface CcorePackage extends EPackage {
	/**
	 * The package name.
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @generated
	 */
	String eNAME = "ccore";

	/**
	 * The package namespace URI.
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @generated
	 */
	String eNS_URI = "http://com.cubemonstergames/UnityCMF/CCore";

	/**
	 * The package namespace name.
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @generated
	 */
	String eNS_PREFIX = "ccore";

	/**
	 * The singleton instance of the package.
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @generated
	 */
	CcorePackage eINSTANCE = com.cubemonstergames.unitycmf.ccore.impl.CcorePackageImpl.init();

	/**
	 * The meta object id for the '{@link com.cubemonstergames.unitycmf.ccore.impl.C2DFieldElementImpl <em>C2D Field Element</em>}' class.
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @see com.cubemonstergames.unitycmf.ccore.impl.C2DFieldElementImpl
	 * @see com.cubemonstergames.unitycmf.ccore.impl.CcorePackageImpl#getC2DFieldElement()
	 * @generated
	 */
	int C2D_FIELD_ELEMENT = 0;

	/**
	 * The feature id for the '<em><b>X</b></em>' attribute.
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @generated
	 * @ordered
	 */
	int C2D_FIELD_ELEMENT__X = 0;

	/**
	 * The feature id for the '<em><b>Y</b></em>' attribute.
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @generated
	 * @ordered
	 */
	int C2D_FIELD_ELEMENT__Y = 1;

	/**
	 * The number of structural features of the '<em>C2D Field Element</em>' class.
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @generated
	 * @ordered
	 */
	int C2D_FIELD_ELEMENT_FEATURE_COUNT = 2;

	/**
	 * The operation id for the '<em>Neighbor</em>' operation.
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @generated
	 * @ordered
	 */
	int C2D_FIELD_ELEMENT___NEIGHBOR__C2DFIELDELEMENT = 0;

	/**
	 * The operation id for the '<em>Distance</em>' operation.
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @generated
	 * @ordered
	 */
	int C2D_FIELD_ELEMENT___DISTANCE__C2DFIELDELEMENT = 1;

	/**
	 * The number of operations of the '<em>C2D Field Element</em>' class.
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @generated
	 * @ordered
	 */
	int C2D_FIELD_ELEMENT_OPERATION_COUNT = 2;

	/**
	 * The meta object id for the '{@link com.cubemonstergames.unitycmf.ccore.Direction <em>Direction</em>}' enum.
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @see com.cubemonstergames.unitycmf.ccore.Direction
	 * @see com.cubemonstergames.unitycmf.ccore.impl.CcorePackageImpl#getDirection()
	 * @generated
	 */
	int DIRECTION = 1;

	/**
	 * The meta object id for the '<em>CAction</em>' data type.
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @see java.lang.Object
	 * @see com.cubemonstergames.unitycmf.ccore.impl.CcorePackageImpl#getCAction()
	 * @generated
	 */
	int CACTION = 2;

	/**
	 * The meta object id for the '<em>CPackage</em>' data type.
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @see java.lang.Object
	 * @see com.cubemonstergames.unitycmf.ccore.impl.CcorePackageImpl#getCPackage()
	 * @generated
	 */
	int CPACKAGE = 3;

	/**
	 * The meta object id for the '<em>CFactory</em>' data type.
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @see java.lang.Object
	 * @see com.cubemonstergames.unitycmf.ccore.impl.CcorePackageImpl#getCFactory()
	 * @generated
	 */
	int CFACTORY = 4;


	/**
	 * The meta object id for the '<em>CUnsinged Int</em>' data type.
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @see java.lang.Object
	 * @see com.cubemonstergames.unitycmf.ccore.impl.CcorePackageImpl#getCUnsingedInt()
	 * @generated
	 */
	int CUNSINGED_INT = 5;


	/**
	 * Returns the meta object for class '{@link com.cubemonstergames.unitycmf.ccore.C2DFieldElement <em>C2D Field Element</em>}'.
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @return the meta object for class '<em>C2D Field Element</em>'.
	 * @see com.cubemonstergames.unitycmf.ccore.C2DFieldElement
	 * @generated
	 */
	EClass getC2DFieldElement();

	/**
	 * Returns the meta object for the attribute '{@link com.cubemonstergames.unitycmf.ccore.C2DFieldElement#getX <em>X</em>}'.
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @return the meta object for the attribute '<em>X</em>'.
	 * @see com.cubemonstergames.unitycmf.ccore.C2DFieldElement#getX()
	 * @see #getC2DFieldElement()
	 * @generated
	 */
	EAttribute getC2DFieldElement_X();

	/**
	 * Returns the meta object for the attribute '{@link com.cubemonstergames.unitycmf.ccore.C2DFieldElement#getY <em>Y</em>}'.
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @return the meta object for the attribute '<em>Y</em>'.
	 * @see com.cubemonstergames.unitycmf.ccore.C2DFieldElement#getY()
	 * @see #getC2DFieldElement()
	 * @generated
	 */
	EAttribute getC2DFieldElement_Y();

	/**
	 * Returns the meta object for the '{@link com.cubemonstergames.unitycmf.ccore.C2DFieldElement#Neighbor(com.cubemonstergames.unitycmf.ccore.C2DFieldElement) <em>Neighbor</em>}' operation.
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @return the meta object for the '<em>Neighbor</em>' operation.
	 * @see com.cubemonstergames.unitycmf.ccore.C2DFieldElement#Neighbor(com.cubemonstergames.unitycmf.ccore.C2DFieldElement)
	 * @generated
	 */
	EOperation getC2DFieldElement__Neighbor__C2DFieldElement();

	/**
	 * Returns the meta object for the '{@link com.cubemonstergames.unitycmf.ccore.C2DFieldElement#Distance(com.cubemonstergames.unitycmf.ccore.C2DFieldElement) <em>Distance</em>}' operation.
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @return the meta object for the '<em>Distance</em>' operation.
	 * @see com.cubemonstergames.unitycmf.ccore.C2DFieldElement#Distance(com.cubemonstergames.unitycmf.ccore.C2DFieldElement)
	 * @generated
	 */
	EOperation getC2DFieldElement__Distance__C2DFieldElement();

	/**
	 * Returns the meta object for enum '{@link com.cubemonstergames.unitycmf.ccore.Direction <em>Direction</em>}'.
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @return the meta object for enum '<em>Direction</em>'.
	 * @see com.cubemonstergames.unitycmf.ccore.Direction
	 * @generated
	 */
	EEnum getDirection();

	/**
	 * Returns the meta object for data type '{@link java.lang.Object <em>CAction</em>}'.
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @return the meta object for data type '<em>CAction</em>'.
	 * @see java.lang.Object
	 * @model instanceClass="java.lang.Object"
	 *        annotation="http://com.cubemonstergames/UnityCMF CInstanceClass='UnityCMF.CCore.CAction'"
	 * @generated
	 */
	EDataType getCAction();

	/**
	 * Returns the meta object for data type '{@link java.lang.Object <em>CPackage</em>}'.
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @return the meta object for data type '<em>CPackage</em>'.
	 * @see java.lang.Object
	 * @model instanceClass="java.lang.Object"
	 *        annotation="http://com.cubemonstergames/UnityCMF CInstanceClass='UnityCMF.CCore.CPackage'"
	 * @generated
	 */
	EDataType getCPackage();

	/**
	 * Returns the meta object for data type '{@link java.lang.Object <em>CFactory</em>}'.
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @return the meta object for data type '<em>CFactory</em>'.
	 * @see java.lang.Object
	 * @model instanceClass="java.lang.Object"
	 *        annotation="http://com.cubemonstergames/UnityCMF CInstanceClass='UnityCMF.CCore.CFactory'"
	 * @generated
	 */
	EDataType getCFactory();

	/**
	 * Returns the meta object for data type '{@link java.lang.Object <em>CUnsinged Int</em>}'.
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @return the meta object for data type '<em>CUnsinged Int</em>'.
	 * @see java.lang.Object
	 * @model instanceClass="java.lang.Object"
	 *        annotation="http://cubemonstergames.com/UnityCMF CInstanceClass='uint'"
	 * @generated
	 */
	EDataType getCUnsingedInt();

	/**
	 * Returns the factory that creates the instances of the model.
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @return the factory that creates the instances of the model.
	 * @generated
	 */
	CcoreFactory getCcoreFactory();

	/**
	 * <!-- begin-user-doc -->
	 * Defines literals for the meta objects that represent
	 * <ul>
	 *   <li>each class,</li>
	 *   <li>each feature of each class,</li>
	 *   <li>each operation of each class,</li>
	 *   <li>each enum,</li>
	 *   <li>and each data type</li>
	 * </ul>
	 * <!-- end-user-doc -->
	 * @generated
	 */
	interface Literals {
		/**
		 * The meta object literal for the '{@link com.cubemonstergames.unitycmf.ccore.impl.C2DFieldElementImpl <em>C2D Field Element</em>}' class.
		 * <!-- begin-user-doc -->
		 * <!-- end-user-doc -->
		 * @see com.cubemonstergames.unitycmf.ccore.impl.C2DFieldElementImpl
		 * @see com.cubemonstergames.unitycmf.ccore.impl.CcorePackageImpl#getC2DFieldElement()
		 * @generated
		 */
		EClass C2D_FIELD_ELEMENT = eINSTANCE.getC2DFieldElement();

		/**
		 * The meta object literal for the '<em><b>X</b></em>' attribute feature.
		 * <!-- begin-user-doc -->
		 * <!-- end-user-doc -->
		 * @generated
		 */
		EAttribute C2D_FIELD_ELEMENT__X = eINSTANCE.getC2DFieldElement_X();

		/**
		 * The meta object literal for the '<em><b>Y</b></em>' attribute feature.
		 * <!-- begin-user-doc -->
		 * <!-- end-user-doc -->
		 * @generated
		 */
		EAttribute C2D_FIELD_ELEMENT__Y = eINSTANCE.getC2DFieldElement_Y();

		/**
		 * The meta object literal for the '<em><b>Neighbor</b></em>' operation.
		 * <!-- begin-user-doc -->
		 * <!-- end-user-doc -->
		 * @generated
		 */
		EOperation C2D_FIELD_ELEMENT___NEIGHBOR__C2DFIELDELEMENT = eINSTANCE.getC2DFieldElement__Neighbor__C2DFieldElement();

		/**
		 * The meta object literal for the '<em><b>Distance</b></em>' operation.
		 * <!-- begin-user-doc -->
		 * <!-- end-user-doc -->
		 * @generated
		 */
		EOperation C2D_FIELD_ELEMENT___DISTANCE__C2DFIELDELEMENT = eINSTANCE.getC2DFieldElement__Distance__C2DFieldElement();

		/**
		 * The meta object literal for the '{@link com.cubemonstergames.unitycmf.ccore.Direction <em>Direction</em>}' enum.
		 * <!-- begin-user-doc -->
		 * <!-- end-user-doc -->
		 * @see com.cubemonstergames.unitycmf.ccore.Direction
		 * @see com.cubemonstergames.unitycmf.ccore.impl.CcorePackageImpl#getDirection()
		 * @generated
		 */
		EEnum DIRECTION = eINSTANCE.getDirection();

		/**
		 * The meta object literal for the '<em>CAction</em>' data type.
		 * <!-- begin-user-doc -->
		 * <!-- end-user-doc -->
		 * @see java.lang.Object
		 * @see com.cubemonstergames.unitycmf.ccore.impl.CcorePackageImpl#getCAction()
		 * @generated
		 */
		EDataType CACTION = eINSTANCE.getCAction();

		/**
		 * The meta object literal for the '<em>CPackage</em>' data type.
		 * <!-- begin-user-doc -->
		 * <!-- end-user-doc -->
		 * @see java.lang.Object
		 * @see com.cubemonstergames.unitycmf.ccore.impl.CcorePackageImpl#getCPackage()
		 * @generated
		 */
		EDataType CPACKAGE = eINSTANCE.getCPackage();

		/**
		 * The meta object literal for the '<em>CFactory</em>' data type.
		 * <!-- begin-user-doc -->
		 * <!-- end-user-doc -->
		 * @see java.lang.Object
		 * @see com.cubemonstergames.unitycmf.ccore.impl.CcorePackageImpl#getCFactory()
		 * @generated
		 */
		EDataType CFACTORY = eINSTANCE.getCFactory();

		/**
		 * The meta object literal for the '<em>CUnsinged Int</em>' data type.
		 * <!-- begin-user-doc -->
		 * <!-- end-user-doc -->
		 * @see java.lang.Object
		 * @see com.cubemonstergames.unitycmf.ccore.impl.CcorePackageImpl#getCUnsingedInt()
		 * @generated
		 */
		EDataType CUNSINGED_INT = eINSTANCE.getCUnsingedInt();

	}

} //CcorePackage
