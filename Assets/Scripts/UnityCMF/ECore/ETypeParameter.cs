using UnityEngine;
using UnityCMF.CCore;
using UnityCMF.ECore;

namespace UnityCMF.ECore {
	 
	public interface ETypeParameter : EModelElement,ENamedElement {
		CList<EGenericType> EBounds { get;  }
		
	}
	
	public class ETypeParameterImpl : ENamedElementImpl, ETypeParameter {
		// PROTECTED REGION ID(ETypeParameter.custom) ENABLED START
	
		// PROTECTED REGION END
		
		public ETypeParameterImpl(UnityCMF.ECore.EClass eClass) : base(eClass) {
			// PROTECTED REGION ID(ETypeParameter.constructor) ENABLED START
	
			// PROTECTED REGION END
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
