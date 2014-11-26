package com.cubemonstergames.unitycmf.generators;

import com.cubemonstergames.unitycmf.generators.GenUtil;
import com.google.common.base.Objects;
import org.eclipse.emf.common.util.EList;
import org.eclipse.emf.ecore.EClass;
import org.eclipse.emf.ecore.EClassifier;
import org.eclipse.emf.ecore.EPackage;
import org.eclipse.emf.ecore.EStructuralFeature;
import org.eclipse.emf.ecore.EcorePackage;
import org.eclipse.xtend2.lib.StringConcatenation;
import org.eclipse.xtext.generator.IFileSystemAccess;
import org.eclipse.xtext.xbase.lib.StringExtensions;

@SuppressWarnings("all")
public class EPackageGenerator {
  private final EPackage ePackage;
  
  public EPackageGenerator(final EPackage ePackage) {
    this.ePackage = ePackage;
  }
  
  public void generate(final IFileSystemAccess fsa) {
    String _packageInterfaceName = GenUtil.packageInterfaceName(this.ePackage);
    String _plus = (_packageInterfaceName + ".cs");
    StringConcatenation _builder = new StringConcatenation();
    {
      boolean _notEquals = (!Objects.equal(this.ePackage, EcorePackage.eINSTANCE));
      if (_notEquals) {
        _builder.append("using UnityCMF.ECore;");
        _builder.newLine();
      }
    }
    _builder.newLine();
    _builder.append("namespace ");
    String _fullPackageName = GenUtil.fullPackageName(this.ePackage);
    _builder.append(_fullPackageName, "");
    _builder.append(" {\t\t\t ");
    _builder.newLineIfNotEmpty();
    _builder.append("\t");
    _builder.append("public interface ");
    String _packageInterfaceName_1 = GenUtil.packageInterfaceName(this.ePackage);
    _builder.append(_packageInterfaceName_1, "	");
    _builder.append(" {");
    _builder.newLineIfNotEmpty();
    _builder.append("\t\t");
    _builder.append("public static ");
    String _packageInterfaceName_2 = GenUtil.packageInterfaceName(this.ePackage);
    _builder.append(_packageInterfaceName_2, "		");
    _builder.append(" cINSTANCE = new ");
    String _packageImplementationName = GenUtil.packageImplementationName(this.ePackage);
    _builder.append(_packageImplementationName, "		");
    _builder.append("();");
    _builder.newLineIfNotEmpty();
    _builder.append("\t\t");
    _builder.newLine();
    {
      EList<EClassifier> _eClassifiers = this.ePackage.getEClassifiers();
      for(final EClassifier eClassifier : _eClassifiers) {
        {
          if ((eClassifier instanceof EClass)) {
            _builder.append("\t\t");
            CharSequence _generatePropertiesForClassInterface = this.generatePropertiesForClassInterface(((EClass) eClassifier));
            _builder.append(_generatePropertiesForClassInterface, "		");
            _builder.newLineIfNotEmpty();
          }
        }
      }
    }
    _builder.append("\t");
    _builder.append("}");
    _builder.newLine();
    _builder.append("\t");
    _builder.newLine();
    _builder.append("\t");
    _builder.append("public class ");
    String _packageImplementationName_1 = GenUtil.packageImplementationName(this.ePackage);
    _builder.append(_packageImplementationName_1, "	");
    _builder.append(" : ");
    String _packageInterfaceName_3 = GenUtil.packageInterfaceName(this.ePackage);
    _builder.append(_packageInterfaceName_3, "	");
    _builder.append(" {");
    _builder.newLineIfNotEmpty();
    _builder.append("\t\t");
    _builder.append("public ");
    String _packageImplementationName_2 = GenUtil.packageImplementationName(this.ePackage);
    _builder.append(_packageImplementationName_2, "		");
    _builder.append("() {");
    _builder.newLineIfNotEmpty();
    {
      EList<EClassifier> _eClassifiers_1 = this.ePackage.getEClassifiers();
      for(final EClassifier eClassifier_1 : _eClassifiers_1) {
        {
          if ((eClassifier_1 instanceof EClass)) {
            _builder.append("\t\t\t");
            CharSequence _generatePropertiesForClassInitialization = this.generatePropertiesForClassInitialization(((EClass) eClassifier_1));
            _builder.append(_generatePropertiesForClassInitialization, "			");
            _builder.newLineIfNotEmpty();
          }
        }
      }
    }
    _builder.append("\t\t");
    _builder.append("}");
    _builder.newLine();
    _builder.append("\t\t");
    _builder.newLine();
    {
      EList<EClassifier> _eClassifiers_2 = this.ePackage.getEClassifiers();
      for(final EClassifier eClassifier_2 : _eClassifiers_2) {
        {
          if ((eClassifier_2 instanceof EClass)) {
            _builder.append("\t\t");
            CharSequence _generatePropertiesForClassImplementation = this.generatePropertiesForClassImplementation(((EClass) eClassifier_2));
            _builder.append(_generatePropertiesForClassImplementation, "		");
            _builder.newLineIfNotEmpty();
          }
        }
      }
    }
    _builder.append("\t");
    _builder.append("}");
    _builder.newLine();
    _builder.append("} // UnityCMF.");
    String _name = this.ePackage.getName();
    _builder.append(_name, "");
    _builder.newLineIfNotEmpty();
    fsa.generateFile(_plus, _builder);
  }
  
  public String packageFeatureProperty(final EStructuralFeature eFeature) {
    StringConcatenation _builder = new StringConcatenation();
    EClass _eContainingClass = eFeature.getEContainingClass();
    String _classifierName = GenUtil.classifierName(_eContainingClass);
    _builder.append(_classifierName, "");
    _builder.append("_");
    String _name = eFeature.getName();
    _builder.append(_name, "");
    return _builder.toString();
  }
  
  public CharSequence generatePropertiesForClassInterface(final EClass eClass) {
    StringConcatenation _builder = new StringConcatenation();
    _builder.append("UnityCMF.ECore.EClass ");
    String _name = eClass.getName();
    String _firstUpper = StringExtensions.toFirstUpper(_name);
    _builder.append(_firstUpper, "");
    _builder.append(" { get; }");
    _builder.newLineIfNotEmpty();
    {
      EList<EStructuralFeature> _eStructuralFeatures = eClass.getEStructuralFeatures();
      for(final EStructuralFeature eFeature : _eStructuralFeatures) {
        {
          boolean _filter = GenUtil.filter(eFeature);
          boolean _not = (!_filter);
          if (_not) {
            _builder.append("EStructuralFeature ");
            String _packageFeatureProperty = this.packageFeatureProperty(eFeature);
            _builder.append(_packageFeatureProperty, "");
            _builder.append(" { get; }");
            _builder.newLineIfNotEmpty();
          }
        }
      }
    }
    return _builder;
  }
  
  public CharSequence generatePropertiesForClassImplementation(final EClass eClass) {
    StringConcatenation _builder = new StringConcatenation();
    _builder.append("public UnityCMF.ECore.EClass ");
    String _name = eClass.getName();
    String _firstUpper = StringExtensions.toFirstUpper(_name);
    _builder.append(_firstUpper, "");
    _builder.append(" { public get; private set;}");
    _builder.newLineIfNotEmpty();
    {
      EList<EStructuralFeature> _eStructuralFeatures = eClass.getEStructuralFeatures();
      for(final EStructuralFeature eFeature : _eStructuralFeatures) {
        {
          boolean _filter = GenUtil.filter(eFeature);
          boolean _not = (!_filter);
          if (_not) {
            _builder.append("public EStructuralFeature ");
            String _packageFeatureProperty = this.packageFeatureProperty(eFeature);
            _builder.append(_packageFeatureProperty, "");
            _builder.append("  { public get; private set;}");
            _builder.newLineIfNotEmpty();
          }
        }
      }
    }
    return _builder;
  }
  
  public CharSequence generatePropertiesForClassInitialization(final EClass eClass) {
    StringConcatenation _builder = new StringConcatenation();
    String _name = eClass.getName();
    String _firstUpper = StringExtensions.toFirstUpper(_name);
    _builder.append(_firstUpper, "");
    _builder.append(" = UnityCMF.ECore.ECoreFactory.cINSTANCE.CreateEClass();");
    _builder.newLineIfNotEmpty();
    String _name_1 = eClass.getName();
    String _firstUpper_1 = StringExtensions.toFirstUpper(_name_1);
    _builder.append(_firstUpper_1, "");
    _builder.append(".Name = \"");
    String _name_2 = eClass.getName();
    _builder.append(_name_2, "");
    _builder.append("\";");
    _builder.newLineIfNotEmpty();
    {
      EList<EStructuralFeature> _eStructuralFeatures = eClass.getEStructuralFeatures();
      for(final EStructuralFeature eFeature : _eStructuralFeatures) {
        {
          boolean _filter = GenUtil.filter(eFeature);
          boolean _not = (!_filter);
          if (_not) {
            String _name_3 = eClass.getName();
            String _firstUpper_2 = StringExtensions.toFirstUpper(_name_3);
            _builder.append(_firstUpper_2, "");
            _builder.append("_");
            String _name_4 = eFeature.getName();
            _builder.append(_name_4, "");
            _builder.append(" = UnityCMF.ECore.ECoreFactory.cINSTANCE.CreateEStructuralFeature();");
            _builder.newLineIfNotEmpty();
            String _name_5 = eClass.getName();
            String _firstUpper_3 = StringExtensions.toFirstUpper(_name_5);
            _builder.append(_firstUpper_3, "");
            _builder.append("_");
            String _name_6 = eFeature.getName();
            _builder.append(_name_6, "");
            _builder.append(".Name = \"");
            String _name_7 = eFeature.getName();
            _builder.append(_name_7, "");
            _builder.append("\";");
            _builder.newLineIfNotEmpty();
            String _name_8 = eClass.getName();
            String _firstUpper_4 = StringExtensions.toFirstUpper(_name_8);
            _builder.append(_firstUpper_4, "");
            _builder.append("_");
            String _name_9 = eFeature.getName();
            _builder.append(_name_9, "");
            _builder.append(".Many = ");
            boolean _isMany = eFeature.isMany();
            _builder.append(_isMany, "");
            _builder.append(";");
            _builder.newLineIfNotEmpty();
            String _name_10 = eClass.getName();
            String _firstUpper_5 = StringExtensions.toFirstUpper(_name_10);
            _builder.append(_firstUpper_5, "");
            _builder.append("_");
            String _name_11 = eFeature.getName();
            _builder.append(_name_11, "");
            _builder.append(".EType = UnityCMF.");
            EClassifier _eType = eFeature.getEType();
            EPackage _ePackage = _eType.getEPackage();
            String _name_12 = _ePackage.getName();
            String _firstUpper_6 = StringExtensions.toFirstUpper(_name_12);
            _builder.append(_firstUpper_6, "");
            _builder.append(".");
            EClassifier _eType_1 = eFeature.getEType();
            EPackage _ePackage_1 = _eType_1.getEPackage();
            String _name_13 = _ePackage_1.getName();
            String _firstUpper_7 = StringExtensions.toFirstUpper(_name_13);
            _builder.append(_firstUpper_7, "");
            _builder.append("Package.cINSTANCE.");
            EClassifier _eType_2 = eFeature.getEType();
            String _name_14 = _eType_2.getName();
            String _firstUpper_8 = StringExtensions.toFirstUpper(_name_14);
            _builder.append(_firstUpper_8, "");
            _builder.append(";");
            _builder.newLineIfNotEmpty();
            String _name_15 = eClass.getName();
            String _firstUpper_9 = StringExtensions.toFirstUpper(_name_15);
            _builder.append(_firstUpper_9, "");
            _builder.append(".EStructuralFeatures.Add(");
            String _name_16 = eClass.getName();
            String _firstUpper_10 = StringExtensions.toFirstUpper(_name_16);
            _builder.append(_firstUpper_10, "");
            _builder.append("_");
            String _name_17 = eFeature.getName();
            _builder.append(_name_17, "");
            _builder.append(");");
            _builder.newLineIfNotEmpty();
          }
        }
      }
    }
    _builder.append("\t\t");
    _builder.newLine();
    return _builder;
  }
}
