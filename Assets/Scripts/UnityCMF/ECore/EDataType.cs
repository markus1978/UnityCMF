using UnityEngine;
using UnityCMF.CCore;
using UnityCMF.ECore;

namespace UnityCMF.ECore {
	 
	public interface EDataType : EModelElement,ENamedElement,EClassifier {
		bool IsSerializable { get; set; }
		
	}
	
	public class EDataTypeImpl : EClassifierImpl, EDataType {
		// PROTECTED REGION ID(EDataType.custom) ENABLED START
	
		// PROTECTED REGION END
		
		public EDataTypeImpl(UnityCMF.ECore.EClass eClass) : base(eClass) {
			// PROTECTED REGION ID(EDataType.constructor) ENABLED START
	
			// PROTECTED REGION END
		}

		
		private bool _IsSerializable;
		public bool IsSerializable {
			get { return _IsSerializable; }
			set {
				bool oldValue = _IsSerializable;
				_IsSerializable = value;
				
				if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.EDataType_serializable)) {
					CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.EDataType_serializable, oldValue, value, -1));
				}	
			}
		}
	}
} // UnityCMF.ecore
