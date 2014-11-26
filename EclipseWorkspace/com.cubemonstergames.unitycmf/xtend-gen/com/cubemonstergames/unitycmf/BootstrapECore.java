package com.cubemonstergames.unitycmf;

import com.cubemonstergames.unitycmf.generators.EClassGenerator;
import com.cubemonstergames.unitycmf.generators.EFactoryGenerator;
import com.cubemonstergames.unitycmf.generators.EPackageGenerator;
import com.google.inject.Injector;
import org.eclipse.emf.common.util.EList;
import org.eclipse.emf.ecore.EClass;
import org.eclipse.emf.ecore.EClassifier;
import org.eclipse.emf.ecore.EcorePackage;
import org.eclipse.xtend.core.XtendInjectorSingleton;
import org.eclipse.xtext.generator.JavaIoFileSystemAccess;

@SuppressWarnings("all")
public class BootstrapECore {
  public static void main(final String[] args) {
    final Injector injector = XtendInjectorSingleton.INJECTOR;
    final JavaIoFileSystemAccess fsa = injector.<JavaIoFileSystemAccess>getInstance(JavaIoFileSystemAccess.class);
    fsa.setOutputPath("../../Assets/Scripts/UnityCMF/ECore/");
    EList<EClassifier> _eClassifiers = EcorePackage.eINSTANCE.getEClassifiers();
    for (final EClassifier eClassifier : _eClassifiers) {
      if ((eClassifier instanceof EClass)) {
        EClassGenerator _eClassGenerator = new EClassGenerator(EcorePackage.eINSTANCE);
        _eClassGenerator.generate(((EClass) eClassifier), fsa);
      }
    }
    EPackageGenerator _ePackageGenerator = new EPackageGenerator(EcorePackage.eINSTANCE);
    _ePackageGenerator.generate(fsa);
    EFactoryGenerator _eFactoryGenerator = new EFactoryGenerator(EcorePackage.eINSTANCE);
    _eFactoryGenerator.generate(fsa);
  }
}
