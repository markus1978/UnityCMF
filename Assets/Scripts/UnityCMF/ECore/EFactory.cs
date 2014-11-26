using UnityCMF.CCore;
using UnityCMF.ECore;

namespace UnityCMF.ECore {
	 
	public interface EFactory : EModelElement {
		EPackage EPackage { get; set; }
	}
	
	public class EFactoryImpl : CObjectImpl, EFactory {
		public EFactoryImpl(UnityCMF.ECore.EClass eClass) : base(eClass) {
		}
		
		private CList<EAnnotation> _EAnnotations;
		public CList<EAnnotation> EAnnotations {
			get {
				if (_EAnnotations == null) {
					EStructuralFeature feature = ECoreMeta.cINSTANCE.Package.EModelElement_eAnnotations;
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
				
				if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.EFactory_ePackage)) {
					CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.EFactory_ePackage, oldValue, value, -1));
				}	
			}
		}
	}
} // UnityCMF.ecore
