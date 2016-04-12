﻿using UnityEngine;
using System.Collections;

namespace VRAVE
{
    public class HUDVRAVE_Default : HUDModel_Upright
    {

        public HUDVRAVE_Default()
        {
			//Text
			centerTextPosition = new Vector3(0.82f, 0.38f, 0.1f);
			leftTextPosition = new Vector3(2.358f, 0.391f, -0.827f);
			rightTextPosition = new Vector3(-0.573f, 0.58f, -0.608f);
			topTextPosition = new Vector3(1.081f, 0.366f, -0.882f);
			//Behind Glass
			//bottomTextPosition = new Vector3(2.59f, 0, 0.08f);
			//In front of glass
			bottomTextPosition = new Vector3(1.86f, 0.39f, 0.08f);

			centerFontSize = 300;
			leftFontSize = 350;
			rightFontSize = 250;
			topFontSize = 350;
			bottomFontSize = 300;

			centerText = "Welcome to Scenario #3!";
			leftText = "Left Text";
			rightText = "Right Text";
			topText = "Top Text";
			bottomText = "Bottom Text";

			isCenterTextEnabled = true;
			isLeftTextEnabled = true;
			isRightTextEnabled = true;
			isTopTextEnabled = true;
			isBottomTextEnabled = true;
		}
    }
}
