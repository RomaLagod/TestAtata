using Atata;

namespace AtataSamples.NetCore.NUnit
{
    using _ = SignInPage;

    public class SignInPage : Page<_>
    {
        [FindById("user_email")]
        public EmailInput<_> Email { get; private set; }

        [FindById("user_password")]
        public PasswordInput<_> Password { get; private set; }

        [FindByCss("#new_user > div.set > div.field-login > button")]
        public Button<_> Login { get; private set; }

        [FindByCss("body > div.fixed > nav > section > ul.right > li > a")]
        public Text<_> Task { get; set; }
    }
}
