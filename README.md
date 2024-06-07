Download deze versie om de diverse account toe te voegen! In de latere versies lukt dat niet meer omdat ze er al in horen te zitten.

https://github.com/harrymaartens/AbbyRazorPagesNET8.0/tree/756442d5e944f3aa91c6553d3b2e02f4830e1573

Gebruik hierna de eindversie om alles te testen.

Ik zit nog wel met een bug waar ik niet uitkom in Menu Item List m.b.t. Globalization namelijk als ik de bedragen aan kan passen tot op de cent nauwkeurig werkt dat, maar als ik bij create new menu item en vul niets in werk validation niet en krijg ik een foutmelding. Als ik de scriptregels omdraai werkt validation wel maar krijg ik bij de bedragen achter de comma een Not a Nunber message.

Hier is het bewuste script:

<script src="~/lib/jquery-validation/dist/jquery.validate.min.js"></script>
<script src="~/lib/jquery-validation-unobtrusive/jquery.validate.unobtrusive.min.js"></script>

<script src="~/lib/validation/cldr.js"></script>
<script src="~/lib/validation/globalize.js"></script>
<script src="~/lib/validation/jquery.validate.globalize.js"></script>


@* <!-- cldr script (needed for globalize) -->
<script src="https://cdn.jsdelivr.net/npm/cldrjs@0.5.5/dist/cldr.min.js"></script>
<!-- globalize script -->
<script src="https://cdn.jsdelivr.net/npm/globalize@1.7.0/dist/globalize.min.js"></script>
<!-- jquery validation script with globalize -->
<script src="https://cdn.jsdelivr.net/npm/jquery-validation-globalize@0.1.1/jquery.validate.globalize.min.js"></script>
 *@
