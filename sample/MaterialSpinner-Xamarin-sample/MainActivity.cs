using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using FR.Ganfra.Materialspinner;
using Android.Support.V7.App;

namespace MaterialSpinnerXamarinsample
{
	[Activity (Label = "MaterialSpinner-Xamarin-sample", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : AppCompatActivity {

		private static readonly string ERROR_MSG = "Now this is a very very very, VERY, VERY long error message to get scrolling or multiline animation when the error button is clicked";
		private static readonly string[] ITEMS = {"Item 1", "Item 2", "Item 3", "Item 4", "Item 5", "Item 6"};

		private ArrayAdapter<String> adapter;

		MaterialSpinner spinner1;
		MaterialSpinner spinner2;
		MaterialSpinner spinner3;
		MaterialSpinner spinner4;
		MaterialSpinner spinner5;

		private bool shown = false;

		protected override void OnCreate(Bundle savedInstanceState) {
			base.OnCreate(savedInstanceState);
			SetContentView(Resource.Layout.Main);

			var btnShowErrors = FindViewById<Button> (Resource.Id.btnShowError);
			btnShowErrors.Click += ActivateError;

			adapter = new ArrayAdapter<String>(this, Android.Resource.Layout.SimpleSpinnerItem, ITEMS);
			adapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);


			InitSpinnerHintAndFloatingLabel();
			InitSpinnerOnlyHint();
			InitSpinnerNoHintNoFloatingLabel();
			InitSpinnerMultiline();
			InitSpinnerScrolling();

		}

		private void InitSpinnerHintAndFloatingLabel() {
			spinner1 = FindViewById<MaterialSpinner>(Resource.Id.spinner1);
			spinner1.Adapter = adapter;
			spinner1.SetPaddingSafe(0,0,0,0);
		}

		private void InitSpinnerOnlyHint() {
			spinner2 = FindViewById<MaterialSpinner>(Resource.Id.spinner2);
			spinner2.Adapter = adapter;
		}

		private void InitSpinnerNoHintNoFloatingLabel() {
			spinner3 = FindViewById<MaterialSpinner>(Resource.Id.spinner3);
			spinner3.Adapter = adapter;
		}

		private void InitSpinnerMultiline() {
			spinner4 = FindViewById<MaterialSpinner>(Resource.Id.spinner4);
			spinner4.Adapter = adapter;
			spinner4.Hint = "Select an item";
		}

		private void InitSpinnerScrolling() {
			spinner5 = FindViewById<MaterialSpinner>(Resource.Id.spinner5);
			spinner5.Adapter = adapter;
			spinner5.Hint = "Select an item";
		}


		public void ActivateError(object sender, EventArgs e) {
			if (!shown) {
				spinner4.Error = ERROR_MSG;
				spinner5.Error = ERROR_MSG;
			} else {
				spinner4.Error = null;
				spinner5.Error = null;
			}
			shown = !shown;

		}


	}
}


