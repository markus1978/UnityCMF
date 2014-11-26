package com.cubemonstergames.unitycmf.generators;

import com.google.common.base.Objects;
import org.eclipse.emf.ecore.EClass;
import org.eclipse.emf.ecore.EClassifier;
import org.eclipse.emf.ecore.EDataType;
import org.eclipse.emf.ecore.EPackage;
import org.eclipse.emf.ecore.EStructuralFeature;
import org.eclipse.emf.ecore.EcorePackage;
import org.eclipse.xtend2.lib.StringConcatenation;
import org.eclipse.xtext.xbase.lib.StringExtensions;

@SuppressWarnings("all")
public class GenUtil {
  public static boolean isSupportedType(final EClassifier eClassifier) {
    boolean _or = false;
    boolean _or_1 = false;
    boolean _or_2 = false;
    boolean _or_3 = false;
    if ((eClassifier instanceof EClass)) {
      _or_3 = true;
    } else {
      String _name = eClassifier.getName();
      boolean _equals = _name.equals("EInt");
      _or_3 = ((eClassifier instanceof EClass) || _equals);
    }
    if (_or_3) {
      _or_2 = true;
    } else {
      String _name_1 = eClassifier.getName();
      boolean _equals_1 = _name_1.equals("EString");
      _or_2 = (_or_3 || _equals_1);
    }
    if (_or_2) {
      _or_1 = true;
    } else {
      String _name_2 = eClassifier.getName();
      boolean _equals_2 = _name_2.equals("EDouble");
      _or_1 = (_or_2 || _equals_2);
    }
    if (_or_1) {
      _or = true;
    } else {
      String _name_3 = eClassifier.getName();
      boolean _equals_3 = _name_3.equals("EBoolean");
      _or = (_or_1 || _equals_3);
    }
    return _or;
  }
  
  public static String primitiveTypeReference(final EDataType type) {
    String _name = type.getName();
    boolean _equals = _name.equals("EInt");
    if (_equals) {
      return "int";
    } else {
      String _name_1 = type.getName();
      boolean _equals_1 = _name_1.equals("EString");
      if (_equals_1) {
        return "string";
      } else {
        String _name_2 = type.getName();
        boolean _equals_2 = _name_2.equals("EDouble");
        if (_equals_2) {
          return "float";
        } else {
          String _name_3 = type.getName();
          boolean _equals_3 = _name_3.equals("EBoolean");
          if (_equals_3) {
            return "bool";
          } else {
            return type.getInstanceTypeName();
          }
        }
      }
    }
  }
  
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
    boolean _or = false;
    boolean _isDerived = eFeature.isDerived();
    if (_isDerived) {
      _or = true;
    } else {
      EClassifier _eType = eFeature.getEType();
      boolean _isSupportedType = GenUtil.isSupportedType(_eType);
      boolean _not = (!_isSupportedType);
      _or = (_isDerived || _not);
    }
    return _or;
  }
  
  public static String packageInterfaceName(final EPackage ePackage) {
    String _packageName = GenUtil.packageName(ePackage);
    return (_packageName + "Package");
  }
  
  public static String packageImplementationName(final EPackage ePackage) {
    String _packageInterfaceName = GenUtil.packageInterfaceName(ePackage);
    return (_packageInterfaceName + "Impl");
  }
  
  public static String metaName(final EPackage ePackage) {
    String _packageName = GenUtil.packageName(ePackage);
    return (_packageName + "Meta");
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
