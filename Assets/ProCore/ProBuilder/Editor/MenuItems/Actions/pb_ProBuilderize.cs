using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;
using ProBuilder2.Common;
using ProBuilder2.EditorCommon;
using ProBuilder2.MeshOperations;
using System.Linq;

namespace ProBuilder2.Actions
{
	/**
	 * Menu interface for the ProBuilderize functions.
	 */
	public class pb_ProBuilderize : Editor
	{
		[MenuItem("Tools/" + pb_Constant.PRODUCT_NAME + "/Actions/ProBuilderize Selection", true, pb_Constant.MENU_ACTIONS + 1)]
		[MenuItem("Tools/" + pb_Constant.PRODUCT_NAME + "/Actions/ProBuilderize Selection (Preserve Faces)", true, pb_Constant.MENU_ACTIONS + 2)]
		public static bool VerifyProBuilderize()
		{
			return Selection.transforms.Length - pbUtil.GetComponents<pb_Object>(Selection.transforms).Length > 0;
		}	

		[MenuItem("Tools/" + pb_Constant.PRODUCT_NAME + "/Actions/ProBuilderize Selection (Preserve Faces)", false, pb_Constant.MENU_ACTIONS + 4)]
		public static void MenuProBuilderizeQuads2()
		{
			pb_Menu_Commands.ProBuilderize(Selection.gameObjects, true);
		}

		[MenuItem("Tools/" + pb_Constant.PRODUCT_NAME + "/Actions/ProBuilderize Selection", false, pb_Constant.MENU_ACTIONS + 3)]
		public static void MenuProBuilderizeTris2()
		{
			pb_Menu_Commands.ProBuilderize(Selection.gameObjects, false);
		}

	// /**
	//  * Duplicates the object and makes it editable.
	//  */
	// public static pb_Object ProBuilderize(Transform t, bool preserveFaces)
	// {

	// 	pb_Object pb = pbMeshOps.CreatePbObjectWithTransform(t, preserveFaces);

	// 	pb_Editor_Utility.SetEntityType(EntityType.Detail, pb.gameObject);

	// 	pb.ToMesh();
	// 	pb.Refresh();
	// 	pb.Optimize();
		
	// 	t.gameObject.SetActive(false);

	// 	return pb;
	// }
	}
}