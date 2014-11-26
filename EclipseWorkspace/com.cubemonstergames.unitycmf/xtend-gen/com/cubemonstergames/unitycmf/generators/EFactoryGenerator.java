package com.cubemonstergames.unitycmf.generators;

import com.cubemonstergames.unitycmf.generators.GenUtil;
import com.google.common.base.Objects;
import org.eclipse.emf.common.util.EList;
import org.eclipse.emf.ecore.EClass;
import org.eclipse.emf.ecore.EClassifier;
import org.eclipse.emf.ecore.EPackage;
import org.eclipse.emf.ecore.EcorePackage;
import org.eclipse.xtend2.lib.StringConcatenation;
import org.eclipse.xtext.generator.IFileSystemAccess;
import org.eclipse.xtext.xbase.lib.StringExtensions;

@SuppressWarnings("all")
public class EFactoryGenerator {
  private final EPackage ePackage;
  
  public EFactoryGenerator(final EPackage ePackage) {
    this.ePackage = ePackage;
  }
  
  public void generate(final IFileSystemAccess fsa) {
    String _factoryInterfaceName = GenUtil.factoryInterfaceName(this.ePackage);
    String _plus = (_factoryInterfaceName + ".cs");
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
    String _factoryInterfaceName_1 = GenUtil.factoryInterfaceName(this.ePackage);
    _builder.append(_factoryInterfaceName_1, "	");
    _builder.append(" {");
    _builder.newLineIfNotEmpty();
    _builder.append("\t\t");
    _builder.append("public static ");
    String _factoryInterfaceName_2 = GenUtil.factoryInterfaceName(this.ePackage);
    _builder.append(_factoryInterfaceName_2, "		");
    _builder.append("Factory cINSTANCE = new ");
    String _factoryImplementationName = GenUtil.factoryImplementationName(this.ePackage);
    _builder.append(_factoryImplementationName, "		");
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
    String _factoryImplementationName_1 = GenUtil.factoryImplementationName(this.ePackage);
    _builder.append(_factoryImplementationName_1, "	");
    _builder.append(" : ");
    String _factoryInterfaceName_3 = GenUtil.factoryInterfaceName(this.ePackage);
    _builder.append(_factoryInterfaceName_3, "	");
    _builder.append(" {");
    _builder.newLineIfNotEmpty();
    {
      EList<EClassifier> _eClassifiers_1 = this.ePackage.getEClassifiers();
      for(final EClassifier eClassifier_1 : _eClassifiers_1) {
        {
          if ((eClassifier_1 instanceof EClass)) {
            _builder.append("\t\t");
            CharSequence _generatePropertiesForClassImplementation = this.generatePropertiesForClassImplementation(((EClass) eClassifier_1));
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
  
  public CharSequence generatePropertiesForClassInterface(final EClass eClass) {
    StringConcatenation _builder = new StringConcatenation();
    _builder.append("UnityCMF.ECore.EClass Create");
    String _name = eClass.getName();
    String _firstUpper = StringExtensions.toFirstUpper(_name);
    _builder.append(_firstUpper, "");
    _builder.append("();");
    _builder.newLineIfNotEmpty();
    return _builder;
  }
  
  public CharSequence generatePropertiesForClassImplementation(final EClass eClass) {
    StringConcatenation _builder = new StringConcatenation();
    _builder.append("public UnityCMF.ECore.EClass Create");
    String _name = eClass.getName();
    String _firstUpper = StringExtensions.toFirstUpper(_name);
    _builder.append(_firstUpper, "");
    _builder.append("() {");
    _builder.newLineIfNotEmpty();
    _builder.append("\t");
    _builder.append("UnityCMF.ECore.EClass eClass = UnityCMF.");
    String _name_1 = this.ePackage.getName();
    String _firstUpper_1 = StringExtensions.toFirstUpper(_name_1);
    _builder.append(_firstUpper_1, "	");
    _builder.append(".");
    String _name_2 = this.ePackage.getName();
    String _firstUpper_2 = StringExtensions.toFirstUpper(_name_2);
    _builder.append(_firstUpper_2, "	");
    _builder.append("Package.cINSTANCE.");
    String _name_3 = eClass.getName();
    String _firstUpper_3 = StringExtensions.toFirstUpper(_name_3);
    _builder.append(_firstUpper_3, "	");
    _builder.append(";");
    _builder.newLineIfNotEmpty();
    _builder.append("\t");
    _builder.append("return new UnityCMF.");
    String _name_4 = this.ePackage.getName();
    String _firstUpper_4 = StringExtensions.toFirstUpper(_name_4);
    _builder.append(_firstUpper_4, "	");
    _builder.append(".");
    String _name_5 = eClass.getName();
    String _firstLower = StringExtensions.toFirstLower(_name_5);
    _builder.append(_firstLower, "	");
    _builder.append("Impl(eClass);");
    _builder.newLineIfNotEmpty();
    _builder.append("}\t\t");
    _builder.newLine();
    return _builder;
  }
}
