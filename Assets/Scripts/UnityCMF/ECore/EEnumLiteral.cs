using UnityCMF.CCore;
using UnityCMF.ECore;

namespace UnityCMF.ECore {
	 
	public interface EEnumLiteral : EModelElement,ENamedElement {
		int Value { get; set; }
		string Literal { get; set; }
		EEnum EEnum { get; set; }
	}
	
	public class EEnumLiteralImpl : CObjectImpl, EEnumLiteral {
		public EEnumLiteralImpl(UnityCMF.ECore.EClass eClass) : base(eClass) {
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
		private int _Value;
		public int Value {
			get { return _Value; }
			set {
				int oldValue = _Value;
				_Value = value;
				
				if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.EEnumLiteral_value)) {
					CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.EEnumLiteral_value, oldValue, value, -1));
				}	
			}
		}
		private string _Literal;
		public string Literal {
			get { return _Literal; }
			set {
				string oldValue = _Literal;
				_Literal = value;
				
				if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.EEnumLiteral_literal)) {
					CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.EEnumLiteral_literal, oldValue, value, -1));
				}	
			}
		}
		private EEnum _EEnum;
		public EEnum EEnum {
			get { return _EEnum; }
			set {
				EEnum oldValue = _EEnum;
				_EEnum = value;
				
				if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.EEnumLiteral_eEnum)) {
					CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.EEnumLiteral_eEnum, oldValue, value, -1));
				}	
			}
		}
	}
} // UnityCMF.ecore
