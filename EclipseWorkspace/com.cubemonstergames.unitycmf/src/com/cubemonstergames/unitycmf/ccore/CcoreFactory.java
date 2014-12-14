/**
 */
package com.cubemonstergames.unitycmf.ccore;

import org.eclipse.emf.ecore.EFactory;

/**
 * <!-- begin-user-doc -->
 * The <b>Factory</b> for the model.
 * It provides a create method for each non-abstract class of the model.
 * <!-- end-user-doc -->
 * @see com.cubemonstergames.unitycmf.ccore.CcorePackage
 * @generated
 */
public interface CcoreFactory extends EFactory {
	/**
	 * The singleton instance of the factory.
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @generated
	 */
	CcoreFactory eINSTANCE = com.cubemonstergames.unitycmf.ccore.impl.CcoreFactoryImpl.init();

	/**
	 * Returns the package supported by this factory.
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @return the package supported by this factory.
	 * @generated
	 */
	CcorePackage getCcorePackage();

} //CcoreFactory
