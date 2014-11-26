package com.cubemonstergames.unitycmf.generators;

import com.google.common.base.Objects;
import org.eclipse.emf.ecore.EClassifier;
import org.eclipse.emf.ecore.EDataType;
import org.eclipse.emf.ecore.EPackage;
import org.eclipse.emf.ecore.EStructuralFeature;
import org.eclipse.emf.ecore.EcorePackage;
import org.eclipse.xtend2.lib.StringConcatenation;
import org.eclipse.xtext.xbase.lib.StringExtensions;

@SuppressWarnings("all")
public class GenUtil {
  public static String propertyName(final EStructuralFeature eFeature) {
    boolean _and = false;
    EClassifier _eType = eFeature.getEType();
    EDataType _eBoolean = EcorePackage.eINSTANCE.getEBoolean();
    boolean _equals = Objects.equal(_eType, _eBoolean);
    if (!_equals) {
      _and = false;
    } else {
      boolean _isMany = eFeature.isMany();
      boolean _not = (!_isMany);
      _and = (_equals && _not);
    }
    if (_and) {
      StringConcatenation _builder = new StringConcatenation();
      _builder.append("Is");
      String _name = eFeature.getName();
      String _firstUpper = StringExtensions.toFirstUpper(_name);
      _builder.append(_firstUpper, "");
      return _builder.toString();
    } else {
      String _name_1 = eFeature.getName();
      return StringExtensions.toFirstUpper(_name_1);
    }
  }
  
  public static String packageName(final EPackage ePackage) {
    boolean _equals = Objects.equal(ePackage, EcorePackage.eINSTANCE);
    if (_equals) {
      return "ECore";
    } else {
      String _name = ePackage.getName();
      return StringExtensions.toFirstUpper(_name);
    }
  }
  
  public static String fullPackageName(final EPackage ePackage) {
    boolean _equals = Objects.equal(ePackage, EcorePackage.eINSTANCE);
    if (_equals) {
      return "UnityCMF.ECore";
    } else {
      StringConcatenation _builder = new StringConcatenation();
      _builder.append("UnityCMF.");
      String _name = ePackage.getName();
      String _firstUpper = StringExtensions.toFirstUpper(_name);
      _builder.append(_firstUpper, "");
      return _builder.toString();
    }
  }
  
  public static String classifierName(final EClassifier eClassifier) {
    String _name = eClassifier.getName();
    return StringExtensions.toFirstUpper(_name);
  }
  
  public static boolean filter(final EStructuralFeature eFeature) {
    boolean _isDerived = eFeature.isDerived();
    return _isDerived;
  }
  
  public static String packageInterfaceName(final EPackage ePackage) {
    String _packageName = GenUtil.packageName(ePackage);
    return (_packageName + "Package");
  }
  
  public static String packageImplementationName(final EPackage ePackage) {
    String _packageInterfaceName = GenUtil.packageInterfaceName(ePackage);
    return (_packageInterfaceName + "Impl");
  }
  
  public static String factoryInterfaceName(final EPackage ePackage) {
    String _packageName = GenUtil.packageName(ePackage);
    return (_packageName + "Factory");
  }
  
  public static String factoryImplementationName(final EPackage ePackage) {
    String _factoryInterfaceName = GenUtil.factoryInterfaceName(ePackage);
    return (_factoryInterfaceName + "Impl");
  }
}
