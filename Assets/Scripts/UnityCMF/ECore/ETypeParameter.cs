using UnityCMF.CCore;
using UnityCMF.ECore;

namespace UnityCMF.ECore {
	 
	public interface ETypeParameter : EModelElement,ENamedElement {
		CList<EGenericType> EBounds { get; }
	}
	
	public class ETypeParameterImpl : CObjectImpl, ETypeParameter {
		public ETypeParameterImpl(UnityCMF.ECore.EClass eClass) : base(eClass) {
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
		private string _Name;
		public string Name {
			get { return _Name; }
			set {
				string oldValue = _Name;
				_Name = value;
				
				if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.ENamedElement_name)) {
					CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.ENamedElement_name, oldValue, value, -1));
				}	
			}
		}
		private CList<EGenericType> _EBounds;
		public CList<EGenericType> EBounds {
			get {
				if (_EBounds == null) {
					EStructuralFeature feature = ECoreMeta.cINSTANCE.Package.ETypeParameter_eBounds;
					_EBounds = new CList<EGenericType>(this, feature);
				}
				return _EBounds;
			}
		}
	}
} // UnityCMF.ecore
