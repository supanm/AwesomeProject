using System;

using Xamarin.Forms;

namespace AwesomeProject
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();

            Item = new Item
            {
                Text = "Item 1",
                Description = "This is an item description.",
                AttributeType = Item.Attribute.Attack,
                Value = 0,
                BodyPartType = Item.BodyPart.Head,
                Range = 0,
            };

            BindingContext = this;
        }

        async void Save_Clicked(object sender, EventArgs e)
        {
            MessagingCenter.Send(this, "AddItem", Item);
            await Navigation.PopToRootAsync();
        }
    }
}
