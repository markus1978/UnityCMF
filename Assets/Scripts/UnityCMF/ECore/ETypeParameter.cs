using UnityCMF.CCore;
using UnityCMF.ECore;
// PROTECTED REGION ID(ETypeParameter.Namespaces) ENABLED START

// PROTECTED REGION END

namespace UnityCMF.ECore {
	public interface ETypeParameter : EModelElement,ENamedElement {
		CList<EGenericType> EBounds { get; }
		
		
	}
	public class ETypeParameterImpl : ENamedElementImpl, ETypeParameter {
	
		public ETypeParameterImpl(UnityCMF.ECore.EClass eClass) : base(eClass) {
			// PROTECTED REGION ID(ETypeParameter.Constructor) ENABLED START
	
			// PROTECTED REGION END
		}
		
		#region client code
		// PROTECTED REGION ID(ETypeParameter.ClientCode) ENABLED START
	
		// PROTECTED REGION END
		#endregion				
	
		#region derived features and operations
		
		#endregion
		
		private CList<EGenericType> _eBounds;
		public  CList<EGenericType> EBounds {
			get {
				if (_eBounds == null) {
					EStructuralFeature feature = ECoreMeta.cINSTANCE.Package.ETypeParameter_EBounds;
					_eBounds = new CList<EGenericType>(false, this, feature);
				}
				return _eBounds;
			}
		}
		
		public override void CSet(EStructuralFeature feature, object value) {
			switch(feature.Name) {
				default: 
					base.CSet(feature, value);
					break;
			}
		}
		
		public override object CGet(EStructuralFeature feature) {
			switch(feature.Name) {
				case "eBounds" : 
					return EBounds;
				default: 
					return base.CGet(feature);
			}
		}
		
		public override void CRemoveContent(CObject value) {
			switch(value.CContainingFeature.Name) {
				case "eBounds" :
					_eBounds.RemoveAt(_eBounds.IndexOf(value)); 
					break;
				default:
					base.CRemoveContent(value);
					break;
			}
		}
	}

} // UnityCMF.ecore
