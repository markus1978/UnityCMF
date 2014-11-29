package com.cubemonstergames.unitycmf.generators;

import com.cubemonstergames.unitycmf.generators.GenUtil;
import com.google.common.base.Objects;
import org.eclipse.emf.common.util.EList;
import org.eclipse.emf.common.util.EMap;
import org.eclipse.emf.ecore.EAnnotation;
import org.eclipse.emf.ecore.EClass;
import org.eclipse.emf.ecore.EClassifier;
import org.eclipse.emf.ecore.EDataType;
import org.eclipse.emf.ecore.EPackage;
import org.eclipse.emf.ecore.EStructuralFeature;
import org.eclipse.xtend2.lib.StringConcatenation;
import org.eclipse.xtext.generator.IFileSystemAccess;
import org.eclipse.xtext.xbase.lib.StringExtensions;

@SuppressWarnings("all")
public class EClassGenerator {
  private final EPackage ePackage;
  
  public EClassGenerator(final EPackage ePackage) {
    this.ePackage = ePackage;
  }
  
  public void generate(final EClass eClass, final IFileSystemAccess fsa) {
    String _name = eClass.getName();
    String _plus = (_name + ".cs");
    StringConcatenation _builder = new StringConcatenation();
    _builder.append("using UnityCMF.CCore;");
    _builder.newLine();
    _builder.append("using UnityCMF.ECore;");
    _builder.newLine();
    _builder.newLine();
    _builder.append("namespace ");
    String _fullPackageName = GenUtil.fullPackageName(this.ePackage);
    _builder.append(_fullPackageName, "");
    _builder.append(" {");
    _builder.newLineIfNotEmpty();
    _builder.append("\t ");
    _builder.newLine();
    _builder.append("\t");
    _builder.append("public interface ");
    String _classifierName = GenUtil.classifierName(eClass);
    _builder.append(_classifierName, "	");
    _builder.append(" : ");
    CharSequence _superInterfaceDeclaration = this.superInterfaceDeclaration(eClass);
    _builder.append(_superInterfaceDeclaration, "	");
    _builder.append(" {");
    _builder.newLineIfNotEmpty();
    {
      EList<EStructuralFeature> _eStructuralFeatures = eClass.getEStructuralFeatures();
      for(final EStructuralFeature eFeature : _eStructuralFeatures) {
        {
          boolean _filter = GenUtil.filter(eFeature);
          boolean _not = (!_filter);
          if (_not) {
            _builder.append("\t\t");
            CharSequence _generateFeatureInterface = this.generateFeatureInterface(eFeature);
            _builder.append(_generateFeatureInterface, "		");
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
    String _classifierName_1 = GenUtil.classifierName(eClass);
    _builder.append(_classifierName_1, "	");
    _builder.append("Impl : CObjectImpl, ");
    String _classifierName_2 = GenUtil.classifierName(eClass);
    _builder.append(_classifierName_2, "	");
    _builder.append(" {");
    _builder.newLineIfNotEmpty();
    _builder.append("\t\t");
    _builder.append("public ");
    String _name_1 = eClass.getName();
    String _firstUpper = StringExtensions.toFirstUpper(_name_1);
    _builder.append(_firstUpper, "		");
    _builder.append("Impl(UnityCMF.ECore.EClass eClass) : base(eClass) {");
    _builder.newLineIfNotEmpty();
    _builder.append("\t\t");
    _builder.append("}");
    _builder.newLine();
    _builder.append("\t\t");
    _builder.newLine();
    {
      EList<EStructuralFeature> _eAllStructuralFeatures = eClass.getEAllStructuralFeatures();
      for(final EStructuralFeature eFeature_1 : _eAllStructuralFeatures) {
        {
          boolean _filter_1 = GenUtil.filter(eFeature_1);
          boolean _not_1 = (!_filter_1);
          if (_not_1) {
            _builder.append("\t\t");
            CharSequence _generateFeatureImplementation = this.generateFeatureImplementation(eFeature_1);
            _builder.append(_generateFeatureImplementation, "		");
            _builder.newLineIfNotEmpty();
          }
        }
      }
    }
    _builder.append("\t");
    _builder.append("}");
    _builder.newLine();
    _builder.append("} // UnityCMF.");
    EPackage _ePackage = eClass.getEPackage();
    String _name_2 = _ePackage.getName();
    _builder.append(_name_2, "");
    _builder.newLineIfNotEmpty();
    fsa.generateFile(_plus, _builder);
  }
  
  public CharSequence superInterfaceDeclaration(final EClass eClass) {
    StringConcatenation _builder = new StringConcatenation();
    {
      EList<EClass> _eAllSuperTypes = eClass.getEAllSuperTypes();
      boolean _isEmpty = _eAllSuperTypes.isEmpty();
      if (_isEmpty) {
        _builder.append("CObject");
      } else {
        {
          EList<EClass> _eAllSuperTypes_1 = eClass.getEAllSuperTypes();
          boolean _hasElements = false;
          for(final EClass superClass : _eAllSuperTypes_1) {
            if (!_hasElements) {
              _hasElements = true;
            } else {
              _builder.appendImmediate(",", "");
            }
            String _name = superClass.getName();
            _builder.append(_name, "");
          }
        }
      }
    }
    return _builder;
  }
  
  public CharSequence generateFeatureInterface(final EStructuralFeature eFeature) {
    StringConcatenation _builder = new StringConcatenation();
    {
      boolean _isMany = eFeature.isMany();
      if (_isMany) {
        {
          String _dimendionsOf2dField = this.dimendionsOf2dField(eFeature);
          boolean _notEquals = (!Objects.equal(_dimendionsOf2dField, null));
          if (_notEquals) {
            _builder.append("C2DField<");
            EClassifier _eType = eFeature.getEType();
            String _typeReference = this.typeReference(_eType);
            _builder.append(_typeReference, "");
            _builder.append("> ");
            String _propertyName = GenUtil.propertyName(eFeature);
            _builder.append(_propertyName, "");
            _builder.append(" { get; }");
            _builder.newLineIfNotEmpty();
          } else {
            _builder.append("CList<");
            EClassifier _eType_1 = eFeature.getEType();
            String _typeReference_1 = this.typeReference(_eType_1);
            _builder.append(_typeReference_1, "");
            _builder.append("> ");
            String _propertyName_1 = GenUtil.propertyName(eFeature);
            _builder.append(_propertyName_1, "");
            _builder.append(" { get; }");
            _builder.newLineIfNotEmpty();
          }
        }
      } else {
        EClassifier _eType_2 = eFeature.getEType();
        String _typeReference_2 = this.typeReference(_eType_2);
        _builder.append(_typeReference_2, "");
        _builder.append(" ");
        String _propertyName_2 = GenUtil.propertyName(eFeature);
        _builder.append(_propertyName_2, "");
        _builder.append(" { get; set; }");
        _builder.newLineIfNotEmpty();
      }
    }
    return _builder;
  }
  
  public CharSequence featureMetaReference(final EStructuralFeature feature) {
    StringConcatenation _builder = new StringConcatenation();
    String _metaName = GenUtil.metaName(this.ePackage);
    _builder.append(_metaName, "");
    _builder.append(".cINSTANCE.Package.");
    EClass _eContainingClass = feature.getEContainingClass();
    String _name = _eContainingClass.getName();
    _builder.append(_name, "");
    _builder.append("_");
    String _name_1 = feature.getName();
    _builder.append(_name_1, "");
    return _builder;
  }
  
  public CharSequence generateFeatureImplementation(final EStructuralFeature eFeature) {
    StringConcatenation _builder = new StringConcatenation();
    {
      boolean _isMany = eFeature.isMany();
      if (_isMany) {
        final String dimensions2dField = this.dimendionsOf2dField(eFeature);
        _builder.newLineIfNotEmpty();
        {
          boolean _notEquals = (!Objects.equal(dimensions2dField, null));
          if (_notEquals) {
            _builder.append("private C2DField<");
            EClassifier _eType = eFeature.getEType();
            String _typeReference = this.typeReference(_eType);
            _builder.append(_typeReference, "");
            _builder.append("> _");
            String _propertyName = GenUtil.propertyName(eFeature);
            _builder.append(_propertyName, "");
            _builder.append(";");
            _builder.newLineIfNotEmpty();
            _builder.append("public C2DField<");
            EClassifier _eType_1 = eFeature.getEType();
            String _typeReference_1 = this.typeReference(_eType_1);
            _builder.append(_typeReference_1, "");
            _builder.append("> ");
            String _propertyName_1 = GenUtil.propertyName(eFeature);
            _builder.append(_propertyName_1, "");
            _builder.append(" {");
            _builder.newLineIfNotEmpty();
            _builder.append("\t");
            _builder.append("get {");
            _builder.newLine();
            _builder.append("\t\t");
            _builder.append("if (_");
            String _propertyName_2 = GenUtil.propertyName(eFeature);
            _builder.append(_propertyName_2, "		");
            _builder.append(" == null) {");
            _builder.newLineIfNotEmpty();
            _builder.append("\t\t\t");
            _builder.append("EStructuralFeature feature = ");
            CharSequence _featureMetaReference = this.featureMetaReference(eFeature);
            _builder.append(_featureMetaReference, "			");
            _builder.append(";");
            _builder.newLineIfNotEmpty();
            _builder.append("\t\t\t");
            _builder.append("_");
            String _propertyName_3 = GenUtil.propertyName(eFeature);
            _builder.append(_propertyName_3, "			");
            _builder.append(" = new C2DField<");
            EClassifier _eType_2 = eFeature.getEType();
            String _typeReference_2 = this.typeReference(_eType_2);
            _builder.append(_typeReference_2, "			");
            _builder.append(">(");
            _builder.append(dimensions2dField, "			");
            _builder.append(", this, feature);");
            _builder.newLineIfNotEmpty();
            _builder.append("\t\t");
            _builder.append("}");
            _builder.newLine();
            _builder.append("\t\t");
            _builder.append("return _");
            String _propertyName_4 = GenUtil.propertyName(eFeature);
            _builder.append(_propertyName_4, "		");
            _builder.append(";");
            _builder.newLineIfNotEmpty();
            _builder.append("\t");
            _builder.append("}");
            _builder.newLine();
            _builder.append("}");
            _builder.newLine();
          } else {
            _builder.append("private CList<");
            EClassifier _eType_3 = eFeature.getEType();
            String _typeReference_3 = this.typeReference(_eType_3);
            _builder.append(_typeReference_3, "");
            _builder.append("> _");
            String _propertyName_5 = GenUtil.propertyName(eFeature);
            _builder.append(_propertyName_5, "");
            _builder.append(";");
            _builder.newLineIfNotEmpty();
            _builder.append("public CList<");
            EClassifier _eType_4 = eFeature.getEType();
            String _typeReference_4 = this.typeReference(_eType_4);
            _builder.append(_typeReference_4, "");
            _builder.append("> ");
            String _propertyName_6 = GenUtil.propertyName(eFeature);
            _builder.append(_propertyName_6, "");
            _builder.append(" {");
            _builder.newLineIfNotEmpty();
            _builder.append("\t");
            _builder.append("get {");
            _builder.newLine();
            _builder.append("\t\t");
            _builder.append("if (_");
            String _propertyName_7 = GenUtil.propertyName(eFeature);
            _builder.append(_propertyName_7, "		");
            _builder.append(" == null) {");
            _builder.newLineIfNotEmpty();
            _builder.append("\t\t\t");
            _builder.append("EStructuralFeature feature = ");
            CharSequence _featureMetaReference_1 = this.featureMetaReference(eFeature);
            _builder.append(_featureMetaReference_1, "			");
            _builder.append(";");
            _builder.newLineIfNotEmpty();
            _builder.append("\t\t\t");
            _builder.append("_");
            String _propertyName_8 = GenUtil.propertyName(eFeature);
            _builder.append(_propertyName_8, "			");
            _builder.append(" = new CList<");
            EClassifier _eType_5 = eFeature.getEType();
            String _typeReference_5 = this.typeReference(_eType_5);
            _builder.append(_typeReference_5, "			");
            _builder.append(">(this, feature);");
            _builder.newLineIfNotEmpty();
            _builder.append("\t\t");
            _builder.append("}");
            _builder.newLine();
            _builder.append("\t\t");
            _builder.append("return _");
            String _propertyName_9 = GenUtil.propertyName(eFeature);
            _builder.append(_propertyName_9, "		");
            _builder.append(";");
            _builder.newLineIfNotEmpty();
            _builder.append("\t");
            _builder.append("}");
            _builder.newLine();
            _builder.append("}");
            _builder.newLine();
          }
        }
      } else {
        _builder.append("private ");
        EClassifier _eType_6 = eFeature.getEType();
        String _typeReference_6 = this.typeReference(_eType_6);
        _builder.append(_typeReference_6, "");
        _builder.append(" _");
        String _propertyName_10 = GenUtil.propertyName(eFeature);
        _builder.append(_propertyName_10, "");
        _builder.append(";");
        _builder.newLineIfNotEmpty();
        _builder.append("public ");
        EClassifier _eType_7 = eFeature.getEType();
        String _typeReference_7 = this.typeReference(_eType_7);
        _builder.append(_typeReference_7, "");
        _builder.append(" ");
        String _propertyName_11 = GenUtil.propertyName(eFeature);
        _builder.append(_propertyName_11, "");
        _builder.append(" {");
        _builder.newLineIfNotEmpty();
        _builder.append("\t");
        _builder.append("get { return _");
        String _propertyName_12 = GenUtil.propertyName(eFeature);
        _builder.append(_propertyName_12, "	");
        _builder.append("; }");
        _builder.newLineIfNotEmpty();
        _builder.append("\t");
        _builder.append("set {");
        _builder.newLine();
        _builder.append("\t\t");
        EClassifier _eType_8 = eFeature.getEType();
        String _typeReference_8 = this.typeReference(_eType_8);
        _builder.append(_typeReference_8, "		");
        _builder.append(" oldValue = _");
        String _propertyName_13 = GenUtil.propertyName(eFeature);
        _builder.append(_propertyName_13, "		");
        _builder.append(";");
        _builder.newLineIfNotEmpty();
        _builder.append("\t\t");
        _builder.append("_");
        String _propertyName_14 = GenUtil.propertyName(eFeature);
        _builder.append(_propertyName_14, "		");
        _builder.append(" = value;");
        _builder.newLineIfNotEmpty();
        _builder.append("\t\t");
        _builder.newLine();
        _builder.append("\t\t");
        _builder.append("if (CNotificationRequired(");
        CharSequence _featureMetaReference_2 = this.featureMetaReference(eFeature);
        _builder.append(_featureMetaReference_2, "		");
        _builder.append(")) {");
        _builder.newLineIfNotEmpty();
        _builder.append("\t\t\t");
        _builder.append("CNotify(new CAction(this, CActionType.SET, ");
        CharSequence _featureMetaReference_3 = this.featureMetaReference(eFeature);
        _builder.append(_featureMetaReference_3, "			");
        _builder.append(", oldValue, value, -1));");
        _builder.newLineIfNotEmpty();
        _builder.append("\t\t");
        _builder.append("}\t");
        _builder.newLine();
        _builder.append("\t");
        _builder.append("}");
        _builder.newLine();
        _builder.append("}");
        _builder.newLine();
      }
    }
    return _builder;
  }
  
  public String typeReference(final EClassifier type) {
    String _xifexpression = null;
    if ((type instanceof EDataType)) {
      return GenUtil.primitiveTypeReference(((EDataType) type));
    } else {
      String _xifexpression_1 = null;
      if ((type instanceof EClass)) {
        EPackage _ePackage = type.getEPackage();
        boolean _equals = Objects.equal(_ePackage, this.ePackage);
        if (_equals) {
          return GenUtil.classifierName(type);
        }
        StringConcatenation _builder = new StringConcatenation();
        EPackage _ePackage_1 = type.getEPackage();
        String _fullPackageName = GenUtil.fullPackageName(_ePackage_1);
        _builder.append(_fullPackageName, "");
        _builder.append(".");
        String _classifierName = GenUtil.classifierName(type);
        _builder.append(_classifierName, "");
        return _builder.toString();
      }
      _xifexpression = _xifexpression_1;
    }
    return _xifexpression;
  }
  
  public String dimendionsOf2dField(final EStructuralFeature feature) {
    EList<EAnnotation> _eAnnotations = feature.getEAnnotations();
    for (final EAnnotation annotation : _eAnnotations) {
      boolean _and = false;
      String _source = annotation.getSource();
      boolean _endsWith = _source.endsWith("UnityCMF");
      if (!_endsWith) {
        _and = false;
      } else {
        EMap<String,String> _details = annotation.getDetails();
        String _get = _details.get("2DField");
        boolean _notEquals = (!Objects.equal(_get, null));
        _and = (_endsWith && _notEquals);
      }
      if (_and) {
        EMap<String,String> _details_1 = annotation.getDetails();
        String _get_1 = _details_1.get("2DField");
        return ((String) _get_1);
      }
    }
    return null;
  }
}
