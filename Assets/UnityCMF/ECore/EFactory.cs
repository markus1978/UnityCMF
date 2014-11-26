using UnityCMF.CCore;

namespace UnityCMF.ECore {
	 
	public interface EFactory : EModelElement {
		EPackage EPackage { get; set; }
	}
	
	public class EFactoryImpl : CObjectImpl, EFactory {
		public EFactoryImpl(UnityCMF.ECore.EClass eClass) {
			EObjectImpl(eClass);
		}
		
		private CList<EAnnotation> _EAnnotations;
		public CList<EAnnotation> EAnnotations {
			get {
				if (_EAnnotations == null) {
					CStructuralFeature feature = UnityCMF.ecore.EcorePackage.cINSTANCE.EModelElement_eAnnotations;
					_EAnnotations = new CList<EAnnotation>(this, feature);
				}
				return _EAnnotations;
			}
		}
		private EPackage _EPackage;
		public EPackage EPackage {
			get { return _EPackage; }
			set {
				EPackage oldValue = _EPackage;
				_EPackage = value;
				
				if (CNotificationRequired(UnityCMF.ecore.EcorePackage.cINSTANCE.EFactory_ePackage)) {
					CNotify(new Action(this, CAction.SET, UnityCMF.ecore.EcorePackage.cINSTANCE.EFactory_ePackage, oldValue, value, -1));
				}	
			}
		}
	}
} // UnityCMF.ecore
