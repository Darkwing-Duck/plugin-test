using UnityEngine;
using UnityEngine.UI;

namespace ConsentManager.ConsentManagerDemo.Scripts
{
	public class BuildInfoPanel : MonoBehaviour
	{
		[SerializeField] private Text pluginVersionField;
		[SerializeField] private Text sdkVersionField;
		[SerializeField] private Text buildDateField;
		[SerializeField] private GameObject buildDatePanel;

		private void Awake()
		{
			buildDatePanel.SetActive(false);
		}

		public void SetPluginVersion(string value)
		{
			pluginVersionField.text = value;
		}

		public void SetSdkVersion(string value)
		{
			sdkVersionField.text = value;
		}

		public void SetBuildDate(string value)
		{
			buildDateField.text = value;
			buildDatePanel.SetActive(!string.IsNullOrEmpty(value));
		}
	}
}