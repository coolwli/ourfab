using UnityEngine;
using System.Threading.Tasks;
namespace CMF
{
    public class CharacterKeyboardInput : CharacterInput
    {
	    [Header("Scripts")]
	    public FloatingJoystick floatingJoystick;

	    public bool jump;

        public override float GetHorizontalMovementInput()
        {
	        return floatingJoystick.Horizontal;
	        
        }

		public override float GetVerticalMovementInput()
		{ 
			return floatingJoystick.Vertical;
		}

		public override bool IsJumpKeyPressed()
		{
			return jump;
		}

		public async void jumpButton()
		{
			jump = true;
			await Task.Delay(1180);
			jump = false;

		}
    }
}
