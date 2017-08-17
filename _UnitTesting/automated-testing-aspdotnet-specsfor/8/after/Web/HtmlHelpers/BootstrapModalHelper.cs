using System;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.Web.WebPages;
using HtmlTags;
using Microsoft.Web.Mvc;

namespace Web.HtmlHelpers
{
	public static class BootstrapModalHelperExtension
	{
		public static BootstrapModalHelper<TModel> BootstrapModalFor<TModel>(
			this HtmlHelper helper)
		{
			return new BootstrapModalHelper<TModel>(helper);
		}
	}

	public class BootstrapModalHelper<TModel> : IHtmlString
	{
		private readonly HtmlHelper _helper;
		private readonly HtmlTag _buttonTag;
		private readonly HtmlTag _modal;
		private readonly HtmlTag _modalTitle;
		private readonly HtmlTag _closeButton;
		private readonly HtmlTag _saveButton;
		private readonly HtmlTag _form;

		public BootstrapModalHelper(HtmlHelper helper)
		{
			_helper = helper;
			_buttonTag = new HtmlTag("a")
					.Attr("href", "#" + typeof(TModel).Name)
					.Attr("data-toggle", "modal");

			_modal = new HtmlTag("div");
			_modal.Id(typeof (TModel).Name)
				.Attr("role", "dialog")
				.AddClasses("modal", "fade");

			var modalDialog = new HtmlTag("div", _modal)
				.AddClass("modal-dialog");


			var modalContent = new HtmlTag("div", modalDialog)
				.AddClass("modal-content");

			_form = new HtmlTag("form", modalContent)
				.Attr("role", "form")
				.Attr("method", "post");

			var modalHeader = new HtmlTag("div", _form)
				.AddClass("modal-header")
				.Append(
					new HtmlTag("button")
						.Attr("type", "button")
						.AddClass("close")
						.Attr("data-dismiss", "modal")
						.AppendHtml("&times;")
				);

			_modalTitle = new HtmlTag("h4", modalHeader)
				.AddClass("modal-title")
				.Text("Form");

			var modalBody = new HtmlTag("div", _form)
				.AddClass("modal-body")
				.AppendHtml(GetEditorBody());

			var modalFooter = new HtmlTag("div", _form)
				.AddClass("modal-footer");

			_closeButton = new HtmlTag("button", modalFooter)
				.Attr("type", "button")
				.Attr("data-dismiss", "modal")
				.AddClasses("btn", "btn-default")
				.Text("Close");

			_saveButton = new HtmlTag("button", modalFooter)
				.Attr("type", "submit")
				.AddClasses("btn", "btn-primary")
				.Text("Save");
		}

		private string GetEditorBody()
		{
			//Make a new HtmlHelper, that way we can let the
			//built-in MVC templating find the best body to use.
			var modelHelper = new HtmlHelper<TModel>(
				_helper.ViewContext, 
				new ViewPage<TModel>());
			return modelHelper.EditorForModel().ToString();
		}

		public BootstrapModalHelper<TModel> PostTo<TController>(
			Expression<Action<TController>> target) where TController : Controller
		{
			var targetUrl = _helper.BuildUrlFromExpression(target);
			_form.Attr("action", targetUrl);

			return this;
		}

		public BootstrapModalHelper<TModel> AddLinkClass(params string[] classes)
		{
			_buttonTag.AddClasses(classes);

			return this;
		}

		public BootstrapModalHelper<TModel> CloseButtonLabel(string label)
		{
			_closeButton.Text(label);
			return this;
		}

		public BootstrapModalHelper<TModel> SaveButtonLabel(string label)
		{
			_saveButton.Text(label);
			return this;
		}

		public BootstrapModalHelper<TModel> LinkBody(
			Func<object, HelperResult> template)
		{
			_buttonTag.AppendHtml(template(null).ToHtmlString());
			return this;
		}

		public BootstrapModalHelper<TModel> Title(string modalTitle)
		{
			_modalTitle.Text(modalTitle);
			return this;
		}

		public string ToHtmlString()
		{
			return _buttonTag.ToHtmlString() + Environment.NewLine
				+ _modal.ToHtmlString();
		}
	}
}