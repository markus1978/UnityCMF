using UnityCMF.CCore;
using UnityCMF.ECore;
// PROTECTED REGION ID(EAnnotation.Namespaces) ENABLED START

// PROTECTED REGION END

namespace UnityCMF.ECore {
	public interface EAnnotation : EModelElement {
		string Source { get; set; }
		void SetSource(string value, object data);
		CList<EStringToStringMapEntry> Details { get; }
		EModelElement EModelElement { get; set; }
		void SetEModelElement(EModelElement value, object data);
		CList<EObject> Contents { get; }
		CList<EObject> References { get; }
		
		
	}
	public class EAnnotationImpl : EModelElementImpl, EAnnotation {
	
		public EAnnotationImpl(UnityCMF.ECore.EClass eClass) : base(eClass) {
			// PROTECTED REGION ID(EAnnotation.Constructor) ENABLED START
	
			// PROTECTED REGION END
		}
		
		#region client code
		// PROTECTED REGION ID(EAnnotation.ClientCode) ENABLED START
	
		// PROTECTED REGION END
		#endregion				
	
		#region derived features and operations
		
		#endregion
		
		private string _source;
		public  string Source {
			get {
				return _source;
			}
			set {
				string oldValue = _source;
				_source = value;
				if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.EAnnotation_Source)) {
					CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.EAnnotation_Source, oldValue, value, -1, null));
				}	
			}
		}
		public  void SetSource(string value, object data) {
			string oldValue = _source;
			_source = value;
			if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.EAnnotation_Source)) {
				CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.EAnnotation_Source, oldValue, value, -1, data));
			}
		}
		
		private CList<EStringToStringMapEntry> _details;
		public  CList<EStringToStringMapEntry> Details {
			get {
				if (_details == null) {
					EStructuralFeature feature = ECoreMeta.cINSTANCE.Package.EAnnotation_Details;
					_details = new CList<EStringToStringMapEntry>(false, this, feature);
				}
				return _details;
			}
		}
		private EModelElement _eModelElement;
		public  EModelElement EModelElement {
			get {
				return _eModelElement;
			}
			set {
				EModelElement oldValue = _eModelElement;
				_eModelElement = value;
				if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.EAnnotation_EModelElement)) {
					CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.EAnnotation_EModelElement, oldValue, value, -1, null));
				}	
			}
		}
		public  void SetEModelElement(EModelElement value, object data) {
			EModelElement oldValue = _eModelElement;
			_eModelElement = value;
			if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.EAnnotation_EModelElement)) {
				CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.EAnnotation_EModelElement, oldValue, value, -1, data));
			}
		}
		
		private CList<EObject> _contents;
		public  CList<EObject> Contents {
			get {
				if (_contents == null) {
					EStructuralFeature feature = ECoreMeta.cINSTANCE.Package.EAnnotation_Contents;
					_contents = new CList<EObject>(false, this, feature);
				}
				return _contents;
			}
		}
		private CList<EObject> _references;
		public  CList<EObject> References {
			get {
				if (_references == null) {
					EStructuralFeature feature = ECoreMeta.cINSTANCE.Package.EAnnotation_References;
					_references = new CList<EObject>(false, this, feature);
				}
				return _references;
			}
		}
		
		public override void CSet(EStructuralFeature feature, object value) {
			switch(feature.Name) {
				case "source" : 
					Source = (string)value;
					break;															
				case "eModelElement" : 
					EModelElement = (EModelElement)value;
					break;															
				default: 
					base.CSet(feature, value);
					break;
			}
		}
		
		public override object CGet(EStructuralFeature feature) {
			switch(feature.Name) {
				case "source" : 
					return Source;
				case "details" : 
					return Details;
				case "eModelElement" : 
					return EModelElement;
				case "contents" : 
					return Contents;
				case "references" : 
					return References;
				default: 
					return base.CGet(feature);
			}
		}
		
		public override void CRemoveContent(CObject value) {
			switch(value.CContainingFeature.Name) {
				case "details" :
					_details.RemoveAt(_details.IndexOf(value)); 
					break;
				case "contents" :
					_contents.RemoveAt(_contents.IndexOf(value)); 
					break;
				default:
					base.CRemoveContent(value);
					break;
			}
		}
	}

} // UnityCMF.ecore
