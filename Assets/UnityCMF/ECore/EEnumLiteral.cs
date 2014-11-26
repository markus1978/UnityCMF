using UnityCMF.CCore;

namespace UnityCMF.ECore {
	 
	public interface EEnumLiteral : EModelElement,ENamedElement {
		int Value { get; set; }
		org.eclipse.emf.common.util.Enumerator Instance { get; set; }
		string Literal { get; set; }
		EEnum EEnum { get; set; }
	}
	
	public class EEnumLiteralImpl : CObjectImpl, EEnumLiteral {
		public EEnumLiteralImpl(UnityCMF.ECore.EClass eClass) {
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
		private string _Name;
		public string Name {
			get { return _Name; }
			set {
				string oldValue = _Name;
				_Name = value;
				
				if (CNotificationRequired(UnityCMF.ecore.EcorePackage.cINSTANCE.ENamedElement_name)) {
					CNotify(new Action(this, CAction.SET, UnityCMF.ecore.EcorePackage.cINSTANCE.ENamedElement_name, oldValue, value, -1));
				}	
			}
		}
		private int _Value;
		public int Value {
			get { return _Value; }
			set {
				int oldValue = _Value;
				_Value = value;
				
				if (CNotificationRequired(UnityCMF.ecore.EcorePackage.cINSTANCE.EEnumLiteral_value)) {
					CNotify(new Action(this, CAction.SET, UnityCMF.ecore.EcorePackage.cINSTANCE.EEnumLiteral_value, oldValue, value, -1));
				}	
			}
		}
		private org.eclipse.emf.common.util.Enumerator _Instance;
		public org.eclipse.emf.common.util.Enumerator Instance {
			get { return _Instance; }
			set {
				org.eclipse.emf.common.util.Enumerator oldValue = _Instance;
				_Instance = value;
				
				if (CNotificationRequired(UnityCMF.ecore.EcorePackage.cINSTANCE.EEnumLiteral_instance)) {
					CNotify(new Action(this, CAction.SET, UnityCMF.ecore.EcorePackage.cINSTANCE.EEnumLiteral_instance, oldValue, value, -1));
				}	
			}
		}
		private string _Literal;
		public string Literal {
			get { return _Literal; }
			set {
				string oldValue = _Literal;
				_Literal = value;
				
				if (CNotificationRequired(UnityCMF.ecore.EcorePackage.cINSTANCE.EEnumLiteral_literal)) {
					CNotify(new Action(this, CAction.SET, UnityCMF.ecore.EcorePackage.cINSTANCE.EEnumLiteral_literal, oldValue, value, -1));
				}	
			}
		}
		private EEnum _EEnum;
		public EEnum EEnum {
			get { return _EEnum; }
			set {
				EEnum oldValue = _EEnum;
				_EEnum = value;
				
				if (CNotificationRequired(UnityCMF.ecore.EcorePackage.cINSTANCE.EEnumLiteral_eEnum)) {
					CNotify(new Action(this, CAction.SET, UnityCMF.ecore.EcorePackage.cINSTANCE.EEnumLiteral_eEnum, oldValue, value, -1));
				}	
			}
		}
	}
} // UnityCMF.ecore
