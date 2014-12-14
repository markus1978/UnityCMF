/**
 */
package com.cubemonstergames.unitycmf.ccore;

import org.eclipse.emf.ecore.EObject;

/**
 * <!-- begin-user-doc -->
 * A representation of the model object '<em><b>C2D Field Element</b></em>'.
 * <!-- end-user-doc -->
 *
 * <p>
 * The following features are supported:
 * <ul>
 *   <li>{@link com.cubemonstergames.unitycmf.ccore.C2DFieldElement#getX <em>X</em>}</li>
 *   <li>{@link com.cubemonstergames.unitycmf.ccore.C2DFieldElement#getY <em>Y</em>}</li>
 * </ul>
 * </p>
 *
 * @see com.cubemonstergames.unitycmf.ccore.CcorePackage#getC2DFieldElement()
 * @model abstract="true"
 * @generated
 */
public interface C2DFieldElement extends EObject {
	/**
	 * Returns the value of the '<em><b>X</b></em>' attribute.
	 * The default value is <code>"-1"</code>.
	 * <!-- begin-user-doc -->
	 * <p>
	 * If the meaning of the '<em>X</em>' attribute isn't clear,
	 * there really should be more of a description here...
	 * </p>
	 * <!-- end-user-doc -->
	 * @return the value of the '<em>X</em>' attribute.
	 * @see #setX(int)
	 * @see com.cubemonstergames.unitycmf.ccore.CcorePackage#getC2DFieldElement_X()
	 * @model default="-1"
	 * @generated
	 */
	int getX();

	/**
	 * Sets the value of the '{@link com.cubemonstergames.unitycmf.ccore.C2DFieldElement#getX <em>X</em>}' attribute.
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @param value the new value of the '<em>X</em>' attribute.
	 * @see #getX()
	 * @generated
	 */
	void setX(int value);

	/**
	 * Returns the value of the '<em><b>Y</b></em>' attribute.
	 * The default value is <code>"-1"</code>.
	 * <!-- begin-user-doc -->
	 * <p>
	 * If the meaning of the '<em>Y</em>' attribute isn't clear,
	 * there really should be more of a description here...
	 * </p>
	 * <!-- end-user-doc -->
	 * @return the value of the '<em>Y</em>' attribute.
	 * @see #setY(int)
	 * @see com.cubemonstergames.unitycmf.ccore.CcorePackage#getC2DFieldElement_Y()
	 * @model default="-1"
	 * @generated
	 */
	int getY();

	/**
	 * Sets the value of the '{@link com.cubemonstergames.unitycmf.ccore.C2DFieldElement#getY <em>Y</em>}' attribute.
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @param value the new value of the '<em>Y</em>' attribute.
	 * @see #getY()
	 * @generated
	 */
	void setY(int value);

	/**
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @model
	 * @generated
	 */
	Direction Neighbor(C2DFieldElement other);

} // C2DFieldElement
