﻿Imports System.Globalization
Imports System.Threading
Imports System.ComponentModel

Public Class Settings

    Private Sub DisplayLanguageCombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DisplayLanguageCombo.SelectedIndexChanged

    End Sub

    Private Sub SignInForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayLanguageCombo.Items.Add("English")
        DisplayLanguageCombo.Items.Add("Japanese")
        DisplayLanguageCombo.Items.Add("Afrikaans")
        DisplayLanguageCombo.Items.Add("Albanian")
        DisplayLanguageCombo.Items.Add("Amharic")
        DisplayLanguageCombo.Items.Add("Arabic")
        DisplayLanguageCombo.Items.Add("Armenian")
        DisplayLanguageCombo.Items.Add("Azerbaijani")
        DisplayLanguageCombo.Items.Add("Basque")
        DisplayLanguageCombo.Items.Add("Belarusian")
        DisplayLanguageCombo.Items.Add("Bengali")
        DisplayLanguageCombo.Items.Add("Bosnian")
        DisplayLanguageCombo.Items.Add("Bulgarian")
        DisplayLanguageCombo.Items.Add("Catalan")
        DisplayLanguageCombo.Items.Add("Cebuano")
        DisplayLanguageCombo.Items.Add("Chichewa")
        DisplayLanguageCombo.Items.Add("Chinese")
        DisplayLanguageCombo.Items.Add("Corsican")
        DisplayLanguageCombo.Items.Add("Croatian")
        DisplayLanguageCombo.Items.Add("Czech")
        DisplayLanguageCombo.Items.Add("Danish")
        DisplayLanguageCombo.Items.Add("Dutch")
        DisplayLanguageCombo.Items.Add("English")
        DisplayLanguageCombo.Items.Add("Esperanto")
        DisplayLanguageCombo.Items.Add("Estonian")
        DisplayLanguageCombo.Items.Add("Filipino")
        DisplayLanguageCombo.Items.Add("Finnish")
        DisplayLanguageCombo.Items.Add("French")
        DisplayLanguageCombo.Items.Add("Frisian")
        DisplayLanguageCombo.Items.Add("Galician")
        DisplayLanguageCombo.Items.Add("Georgian")
        DisplayLanguageCombo.Items.Add("German")
        DisplayLanguageCombo.Items.Add("Greek")
        DisplayLanguageCombo.Items.Add("Gujarati")
        DisplayLanguageCombo.Items.Add("Haitian Creole")
        DisplayLanguageCombo.Items.Add("Hausa")
        DisplayLanguageCombo.Items.Add("Hawaiian")
        DisplayLanguageCombo.Items.Add("Hebrew")
        DisplayLanguageCombo.Items.Add("Hindi")
        DisplayLanguageCombo.Items.Add("Hmong")
        DisplayLanguageCombo.Items.Add("Hungarian")
        DisplayLanguageCombo.Items.Add("Icelandic")
        DisplayLanguageCombo.Items.Add("Igbo")
        DisplayLanguageCombo.Items.Add("Indonesian")
        DisplayLanguageCombo.Items.Add("Irish")
        DisplayLanguageCombo.Items.Add("Italian")
        DisplayLanguageCombo.Items.Add("Japanese")
        DisplayLanguageCombo.Items.Add("Javanese")
        DisplayLanguageCombo.Items.Add("Kannada")
        DisplayLanguageCombo.Items.Add("Kazakh")
        DisplayLanguageCombo.Items.Add("Khmer")
        DisplayLanguageCombo.Items.Add("Korean")
        DisplayLanguageCombo.Items.Add("Kurdish (Kurmanji)")
        DisplayLanguageCombo.Items.Add("Kyrgyz")
        DisplayLanguageCombo.Items.Add("Lao")
        DisplayLanguageCombo.Items.Add("Latin")
        DisplayLanguageCombo.Items.Add("Latvian")
        DisplayLanguageCombo.Items.Add("Lithuanian")
        DisplayLanguageCombo.Items.Add("Luxembourgish")
        DisplayLanguageCombo.Items.Add("Macedonian")
        DisplayLanguageCombo.Items.Add("Malagasy")
        DisplayLanguageCombo.Items.Add("Malay")
        DisplayLanguageCombo.Items.Add("Malayalam")
        DisplayLanguageCombo.Items.Add("Maltese")
        DisplayLanguageCombo.Items.Add("Maori")
        DisplayLanguageCombo.Items.Add("Marathi")
        DisplayLanguageCombo.Items.Add("Mongolian")
        DisplayLanguageCombo.Items.Add("Myanmar (Burmese)")
        DisplayLanguageCombo.Items.Add("Nepali")
        DisplayLanguageCombo.Items.Add("Norwegian")
        DisplayLanguageCombo.Items.Add("Pashto")
        DisplayLanguageCombo.Items.Add("Persian")
        DisplayLanguageCombo.Items.Add("Polish")
        DisplayLanguageCombo.Items.Add("Portuguese")
        DisplayLanguageCombo.Items.Add("Punjabi")
        DisplayLanguageCombo.Items.Add("Romanian")
        DisplayLanguageCombo.Items.Add("Russian")
        DisplayLanguageCombo.Items.Add("Samoan")
        DisplayLanguageCombo.Items.Add("Scots Gaelic")
        DisplayLanguageCombo.Items.Add("Serbian")
        DisplayLanguageCombo.Items.Add("Sesotho")
        DisplayLanguageCombo.Items.Add("Shona")
        DisplayLanguageCombo.Items.Add("Sindhi")
        DisplayLanguageCombo.Items.Add("Sinhala")
        DisplayLanguageCombo.Items.Add("Slovak")
        DisplayLanguageCombo.Items.Add("Slovenian")
        DisplayLanguageCombo.Items.Add("Somali")
        DisplayLanguageCombo.Items.Add("Spanish")
        DisplayLanguageCombo.Items.Add("Sundanese")
        DisplayLanguageCombo.Items.Add("Swahili")
        DisplayLanguageCombo.Items.Add("Swedish")
        DisplayLanguageCombo.Items.Add("Tajik")
        DisplayLanguageCombo.Items.Add("Tamil")
        DisplayLanguageCombo.Items.Add("Telugu")
        DisplayLanguageCombo.Items.Add("Thai")
        DisplayLanguageCombo.Items.Add("Turkish")
        DisplayLanguageCombo.Items.Add("Ukrainian")
        DisplayLanguageCombo.Items.Add("Urdu")
        DisplayLanguageCombo.Items.Add("Uzbek")
        DisplayLanguageCombo.Items.Add("Vietnamese")
        DisplayLanguageCombo.Items.Add("Welsh")
        DisplayLanguageCombo.Items.Add("Xhosa")
        DisplayLanguageCombo.Items.Add("Yiddish")
        DisplayLanguageCombo.Items.Add("Yoruba")
        DisplayLanguageCombo.Items.Add("Zulu")
        DisplayLanguageCombo.SelectedIndex = 0


        LearningLanguage1.Items.Add("")
        LearningLanguage1.Items.Add("English")
        LearningLanguage1.Items.Add("Japanese")
        LearningLanguage1.Items.Add("Afrikaans")
        LearningLanguage1.Items.Add("Albanian")
        LearningLanguage1.Items.Add("Amharic")
        LearningLanguage1.Items.Add("Arabic")
        LearningLanguage1.Items.Add("Armenian")
        LearningLanguage1.Items.Add("Azerbaijani")
        LearningLanguage1.Items.Add("Basque")
        LearningLanguage1.Items.Add("Belarusian")
        LearningLanguage1.Items.Add("Bengali")
        LearningLanguage1.Items.Add("Bosnian")
        LearningLanguage1.Items.Add("Bulgarian")
        LearningLanguage1.Items.Add("Catalan")
        LearningLanguage1.Items.Add("Cebuano")
        LearningLanguage1.Items.Add("Chichewa")
        LearningLanguage1.Items.Add("Chinese")
        LearningLanguage1.Items.Add("Corsican")
        LearningLanguage1.Items.Add("Croatian")
        LearningLanguage1.Items.Add("Czech")
        LearningLanguage1.Items.Add("Danish")
        LearningLanguage1.Items.Add("Dutch")
        LearningLanguage1.Items.Add("English")
        LearningLanguage1.Items.Add("Esperanto")
        LearningLanguage1.Items.Add("Estonian")
        LearningLanguage1.Items.Add("Filipino")
        LearningLanguage1.Items.Add("Finnish")
        LearningLanguage1.Items.Add("French")
        LearningLanguage1.Items.Add("Frisian")
        LearningLanguage1.Items.Add("Galician")
        LearningLanguage1.Items.Add("Georgian")
        LearningLanguage1.Items.Add("German")
        LearningLanguage1.Items.Add("Greek")
        LearningLanguage1.Items.Add("Gujarati")
        LearningLanguage1.Items.Add("Haitian Creole")
        LearningLanguage1.Items.Add("Hausa")
        LearningLanguage1.Items.Add("Hawaiian")
        LearningLanguage1.Items.Add("Hebrew")
        LearningLanguage1.Items.Add("Hindi")
        LearningLanguage1.Items.Add("Hmong")
        LearningLanguage1.Items.Add("Hungarian")
        LearningLanguage1.Items.Add("Icelandic")
        LearningLanguage1.Items.Add("Igbo")
        LearningLanguage1.Items.Add("Indonesian")
        LearningLanguage1.Items.Add("Irish")
        LearningLanguage1.Items.Add("Italian")
        LearningLanguage1.Items.Add("Japanese")
        LearningLanguage1.Items.Add("Javanese")
        LearningLanguage1.Items.Add("Kannada")
        LearningLanguage1.Items.Add("Kazakh")
        LearningLanguage1.Items.Add("Khmer")
        LearningLanguage1.Items.Add("Korean")
        LearningLanguage1.Items.Add("Kurdish (Kurmanji)")
        LearningLanguage1.Items.Add("Kyrgyz")
        LearningLanguage1.Items.Add("Lao")
        LearningLanguage1.Items.Add("Latin")
        LearningLanguage1.Items.Add("Latvian")
        LearningLanguage1.Items.Add("Lithuanian")
        LearningLanguage1.Items.Add("Luxembourgish")
        LearningLanguage1.Items.Add("Macedonian")
        LearningLanguage1.Items.Add("Malagasy")
        LearningLanguage1.Items.Add("Malay")
        LearningLanguage1.Items.Add("Malayalam")
        LearningLanguage1.Items.Add("Maltese")
        LearningLanguage1.Items.Add("Maori")
        LearningLanguage1.Items.Add("Marathi")
        LearningLanguage1.Items.Add("Mongolian")
        LearningLanguage1.Items.Add("Myanmar (Burmese)")
        LearningLanguage1.Items.Add("Nepali")
        LearningLanguage1.Items.Add("Norwegian")
        LearningLanguage1.Items.Add("Pashto")
        LearningLanguage1.Items.Add("Persian")
        LearningLanguage1.Items.Add("Polish")
        LearningLanguage1.Items.Add("Portuguese")
        LearningLanguage1.Items.Add("Punjabi")
        LearningLanguage1.Items.Add("Romanian")
        LearningLanguage1.Items.Add("Russian")
        LearningLanguage1.Items.Add("Samoan")
        LearningLanguage1.Items.Add("Scots Gaelic")
        LearningLanguage1.Items.Add("Serbian")
        LearningLanguage1.Items.Add("Sesotho")
        LearningLanguage1.Items.Add("Shona")
        LearningLanguage1.Items.Add("Sindhi")
        LearningLanguage1.Items.Add("Sinhala")
        LearningLanguage1.Items.Add("Slovak")
        LearningLanguage1.Items.Add("Slovenian")
        LearningLanguage1.Items.Add("Somali")
        LearningLanguage1.Items.Add("Spanish")
        LearningLanguage1.Items.Add("Sundanese")
        LearningLanguage1.Items.Add("Swahili")
        LearningLanguage1.Items.Add("Swedish")
        LearningLanguage1.Items.Add("Tajik")
        LearningLanguage1.Items.Add("Tamil")
        LearningLanguage1.Items.Add("Telugu")
        LearningLanguage1.Items.Add("Thai")
        LearningLanguage1.Items.Add("Turkish")
        LearningLanguage1.Items.Add("Ukrainian")
        LearningLanguage1.Items.Add("Urdu")
        LearningLanguage1.Items.Add("Uzbek")
        LearningLanguage1.Items.Add("Vietnamese")
        LearningLanguage1.Items.Add("Welsh")
        LearningLanguage1.Items.Add("Xhosa")
        LearningLanguage1.Items.Add("Yiddish")
        LearningLanguage1.Items.Add("Yoruba")
        LearningLanguage1.Items.Add("Zulu")
        LearningLanguage1.SelectedIndex = 0


        LearningLanguage2.Items.Add("")
        LearningLanguage2.Items.Add("English")
        LearningLanguage2.Items.Add("Japanese")
        LearningLanguage2.Items.Add("Afrikaans")
        LearningLanguage2.Items.Add("Albanian")
        LearningLanguage2.Items.Add("Amharic")
        LearningLanguage2.Items.Add("Arabic")
        LearningLanguage2.Items.Add("Armenian")
        LearningLanguage2.Items.Add("Azerbaijani")
        LearningLanguage2.Items.Add("Basque")
        LearningLanguage2.Items.Add("Belarusian")
        LearningLanguage2.Items.Add("Bengali")
        LearningLanguage2.Items.Add("Bosnian")
        LearningLanguage2.Items.Add("Bulgarian")
        LearningLanguage2.Items.Add("Catalan")
        LearningLanguage2.Items.Add("Cebuano")
        LearningLanguage2.Items.Add("Chichewa")
        LearningLanguage2.Items.Add("Chinese")
        LearningLanguage2.Items.Add("Corsican")
        LearningLanguage2.Items.Add("Croatian")
        LearningLanguage2.Items.Add("Czech")
        LearningLanguage2.Items.Add("Danish")
        LearningLanguage2.Items.Add("Dutch")
        LearningLanguage2.Items.Add("English")
        LearningLanguage2.Items.Add("Esperanto")
        LearningLanguage2.Items.Add("Estonian")
        LearningLanguage2.Items.Add("Filipino")
        LearningLanguage2.Items.Add("Finnish")
        LearningLanguage2.Items.Add("French")
        LearningLanguage2.Items.Add("Frisian")
        LearningLanguage2.Items.Add("Galician")
        LearningLanguage2.Items.Add("Georgian")
        LearningLanguage2.Items.Add("German")
        LearningLanguage2.Items.Add("Greek")
        LearningLanguage2.Items.Add("Gujarati")
        LearningLanguage2.Items.Add("Haitian Creole")
        LearningLanguage2.Items.Add("Hausa")
        LearningLanguage2.Items.Add("Hawaiian")
        LearningLanguage2.Items.Add("Hebrew")
        LearningLanguage2.Items.Add("Hindi")
        LearningLanguage2.Items.Add("Hmong")
        LearningLanguage2.Items.Add("Hungarian")
        LearningLanguage2.Items.Add("Icelandic")
        LearningLanguage2.Items.Add("Igbo")
        LearningLanguage2.Items.Add("Indonesian")
        LearningLanguage2.Items.Add("Irish")
        LearningLanguage2.Items.Add("Italian")
        LearningLanguage2.Items.Add("Japanese")
        LearningLanguage2.Items.Add("Javanese")
        LearningLanguage2.Items.Add("Kannada")
        LearningLanguage2.Items.Add("Kazakh")
        LearningLanguage2.Items.Add("Khmer")
        LearningLanguage2.Items.Add("Korean")
        LearningLanguage2.Items.Add("Kurdish (Kurmanji)")
        LearningLanguage2.Items.Add("Kyrgyz")
        LearningLanguage2.Items.Add("Lao")
        LearningLanguage2.Items.Add("Latin")
        LearningLanguage2.Items.Add("Latvian")
        LearningLanguage2.Items.Add("Lithuanian")
        LearningLanguage2.Items.Add("Luxembourgish")
        LearningLanguage2.Items.Add("Macedonian")
        LearningLanguage2.Items.Add("Malagasy")
        LearningLanguage2.Items.Add("Malay")
        LearningLanguage2.Items.Add("Malayalam")
        LearningLanguage2.Items.Add("Maltese")
        LearningLanguage2.Items.Add("Maori")
        LearningLanguage2.Items.Add("Marathi")
        LearningLanguage2.Items.Add("Mongolian")
        LearningLanguage2.Items.Add("Myanmar (Burmese)")
        LearningLanguage2.Items.Add("Nepali")
        LearningLanguage2.Items.Add("Norwegian")
        LearningLanguage2.Items.Add("Pashto")
        LearningLanguage2.Items.Add("Persian")
        LearningLanguage2.Items.Add("Polish")
        LearningLanguage2.Items.Add("Portuguese")
        LearningLanguage2.Items.Add("Punjabi")
        LearningLanguage2.Items.Add("Romanian")
        LearningLanguage2.Items.Add("Russian")
        LearningLanguage2.Items.Add("Samoan")
        LearningLanguage2.Items.Add("Scots Gaelic")
        LearningLanguage2.Items.Add("Serbian")
        LearningLanguage2.Items.Add("Sesotho")
        LearningLanguage2.Items.Add("Shona")
        LearningLanguage2.Items.Add("Sindhi")
        LearningLanguage2.Items.Add("Sinhala")
        LearningLanguage2.Items.Add("Slovak")
        LearningLanguage2.Items.Add("Slovenian")
        LearningLanguage2.Items.Add("Somali")
        LearningLanguage2.Items.Add("Spanish")
        LearningLanguage2.Items.Add("Sundanese")
        LearningLanguage2.Items.Add("Swahili")
        LearningLanguage2.Items.Add("Swedish")
        LearningLanguage2.Items.Add("Tajik")
        LearningLanguage2.Items.Add("Tamil")
        LearningLanguage2.Items.Add("Telugu")
        LearningLanguage2.Items.Add("Thai")
        LearningLanguage2.Items.Add("Turkish")
        LearningLanguage2.Items.Add("Ukrainian")
        LearningLanguage2.Items.Add("Urdu")
        LearningLanguage2.Items.Add("Uzbek")
        LearningLanguage2.Items.Add("Vietnamese")
        LearningLanguage2.Items.Add("Welsh")
        LearningLanguage2.Items.Add("Xhosa")
        LearningLanguage2.Items.Add("Yiddish")
        LearningLanguage2.Items.Add("Yoruba")
        LearningLanguage2.Items.Add("Zulu")
        LearningLanguage2.SelectedIndex = 0


        LearningLanguage3.Items.Add("")
        LearningLanguage3.Items.Add("English")
        LearningLanguage3.Items.Add("Japanese")
        LearningLanguage3.Items.Add("Afrikaans")
        LearningLanguage3.Items.Add("Albanian")
        LearningLanguage3.Items.Add("Amharic")
        LearningLanguage3.Items.Add("Arabic")
        LearningLanguage3.Items.Add("Armenian")
        LearningLanguage3.Items.Add("Azerbaijani")
        LearningLanguage3.Items.Add("Basque")
        LearningLanguage3.Items.Add("Belarusian")
        LearningLanguage3.Items.Add("Bengali")
        LearningLanguage3.Items.Add("Bosnian")
        LearningLanguage3.Items.Add("Bulgarian")
        LearningLanguage3.Items.Add("Catalan")
        LearningLanguage3.Items.Add("Cebuano")
        LearningLanguage3.Items.Add("Chichewa")
        LearningLanguage3.Items.Add("Chinese")
        LearningLanguage3.Items.Add("Corsican")
        LearningLanguage3.Items.Add("Croatian")
        LearningLanguage3.Items.Add("Czech")
        LearningLanguage3.Items.Add("Danish")
        LearningLanguage3.Items.Add("Dutch")
        LearningLanguage3.Items.Add("English")
        LearningLanguage3.Items.Add("Esperanto")
        LearningLanguage3.Items.Add("Estonian")
        LearningLanguage3.Items.Add("Filipino")
        LearningLanguage3.Items.Add("Finnish")
        LearningLanguage3.Items.Add("French")
        LearningLanguage3.Items.Add("Frisian")
        LearningLanguage3.Items.Add("Galician")
        LearningLanguage3.Items.Add("Georgian")
        LearningLanguage3.Items.Add("German")
        LearningLanguage3.Items.Add("Greek")
        LearningLanguage3.Items.Add("Gujarati")
        LearningLanguage3.Items.Add("Haitian Creole")
        LearningLanguage3.Items.Add("Hausa")
        LearningLanguage3.Items.Add("Hawaiian")
        LearningLanguage3.Items.Add("Hebrew")
        LearningLanguage3.Items.Add("Hindi")
        LearningLanguage3.Items.Add("Hmong")
        LearningLanguage3.Items.Add("Hungarian")
        LearningLanguage3.Items.Add("Icelandic")
        LearningLanguage3.Items.Add("Igbo")
        LearningLanguage3.Items.Add("Indonesian")
        LearningLanguage3.Items.Add("Irish")
        LearningLanguage3.Items.Add("Italian")
        LearningLanguage3.Items.Add("Japanese")
        LearningLanguage3.Items.Add("Javanese")
        LearningLanguage3.Items.Add("Kannada")
        LearningLanguage3.Items.Add("Kazakh")
        LearningLanguage3.Items.Add("Khmer")
        LearningLanguage3.Items.Add("Korean")
        LearningLanguage3.Items.Add("Kurdish (Kurmanji)")
        LearningLanguage3.Items.Add("Kyrgyz")
        LearningLanguage3.Items.Add("Lao")
        LearningLanguage3.Items.Add("Latin")
        LearningLanguage3.Items.Add("Latvian")
        LearningLanguage3.Items.Add("Lithuanian")
        LearningLanguage3.Items.Add("Luxembourgish")
        LearningLanguage3.Items.Add("Macedonian")
        LearningLanguage3.Items.Add("Malagasy")
        LearningLanguage3.Items.Add("Malay")
        LearningLanguage3.Items.Add("Malayalam")
        LearningLanguage3.Items.Add("Maltese")
        LearningLanguage3.Items.Add("Maori")
        LearningLanguage3.Items.Add("Marathi")
        LearningLanguage3.Items.Add("Mongolian")
        LearningLanguage3.Items.Add("Myanmar (Burmese)")
        LearningLanguage3.Items.Add("Nepali")
        LearningLanguage3.Items.Add("Norwegian")
        LearningLanguage3.Items.Add("Pashto")
        LearningLanguage3.Items.Add("Persian")
        LearningLanguage3.Items.Add("Polish")
        LearningLanguage3.Items.Add("Portuguese")
        LearningLanguage3.Items.Add("Punjabi")
        LearningLanguage3.Items.Add("Romanian")
        LearningLanguage3.Items.Add("Russian")
        LearningLanguage3.Items.Add("Samoan")
        LearningLanguage3.Items.Add("Scots Gaelic")
        LearningLanguage3.Items.Add("Serbian")
        LearningLanguage3.Items.Add("Sesotho")
        LearningLanguage3.Items.Add("Shona")
        LearningLanguage3.Items.Add("Sindhi")
        LearningLanguage3.Items.Add("Sinhala")
        LearningLanguage3.Items.Add("Slovak")
        LearningLanguage3.Items.Add("Slovenian")
        LearningLanguage3.Items.Add("Somali")
        LearningLanguage3.Items.Add("Spanish")
        LearningLanguage3.Items.Add("Sundanese")
        LearningLanguage3.Items.Add("Swahili")
        LearningLanguage3.Items.Add("Swedish")
        LearningLanguage3.Items.Add("Tajik")
        LearningLanguage3.Items.Add("Tamil")
        LearningLanguage3.Items.Add("Telugu")
        LearningLanguage3.Items.Add("Thai")
        LearningLanguage3.Items.Add("Turkish")
        LearningLanguage3.Items.Add("Ukrainian")
        LearningLanguage3.Items.Add("Urdu")
        LearningLanguage3.Items.Add("Uzbek")
        LearningLanguage3.Items.Add("Vietnamese")
        LearningLanguage3.Items.Add("Welsh")
        LearningLanguage3.Items.Add("Xhosa")
        LearningLanguage3.Items.Add("Yiddish")
        LearningLanguage3.Items.Add("Yoruba")
        LearningLanguage3.Items.Add("Zulu")
        LearningLanguage3.SelectedIndex = 0


        LearningLanguage4.Items.Add("")
        LearningLanguage4.Items.Add("English")
        LearningLanguage4.Items.Add("Japanese")
        LearningLanguage4.Items.Add("Afrikaans")
        LearningLanguage4.Items.Add("Albanian")
        LearningLanguage4.Items.Add("Amharic")
        LearningLanguage4.Items.Add("Arabic")
        LearningLanguage4.Items.Add("Armenian")
        LearningLanguage4.Items.Add("Azerbaijani")
        LearningLanguage4.Items.Add("Basque")
        LearningLanguage4.Items.Add("Belarusian")
        LearningLanguage4.Items.Add("Bengali")
        LearningLanguage4.Items.Add("Bosnian")
        LearningLanguage4.Items.Add("Bulgarian")
        LearningLanguage4.Items.Add("Catalan")
        LearningLanguage4.Items.Add("Cebuano")
        LearningLanguage4.Items.Add("Chichewa")
        LearningLanguage4.Items.Add("Chinese")
        LearningLanguage4.Items.Add("Corsican")
        LearningLanguage4.Items.Add("Croatian")
        LearningLanguage4.Items.Add("Czech")
        LearningLanguage4.Items.Add("Danish")
        LearningLanguage4.Items.Add("Dutch")
        LearningLanguage4.Items.Add("English")
        LearningLanguage4.Items.Add("Esperanto")
        LearningLanguage4.Items.Add("Estonian")
        LearningLanguage4.Items.Add("Filipino")
        LearningLanguage4.Items.Add("Finnish")
        LearningLanguage4.Items.Add("French")
        LearningLanguage4.Items.Add("Frisian")
        LearningLanguage4.Items.Add("Galician")
        LearningLanguage4.Items.Add("Georgian")
        LearningLanguage4.Items.Add("German")
        LearningLanguage4.Items.Add("Greek")
        LearningLanguage4.Items.Add("Gujarati")
        LearningLanguage4.Items.Add("Haitian Creole")
        LearningLanguage4.Items.Add("Hausa")
        LearningLanguage4.Items.Add("Hawaiian")
        LearningLanguage4.Items.Add("Hebrew")
        LearningLanguage4.Items.Add("Hindi")
        LearningLanguage4.Items.Add("Hmong")
        LearningLanguage4.Items.Add("Hungarian")
        LearningLanguage4.Items.Add("Icelandic")
        LearningLanguage4.Items.Add("Igbo")
        LearningLanguage4.Items.Add("Indonesian")
        LearningLanguage4.Items.Add("Irish")
        LearningLanguage4.Items.Add("Italian")
        LearningLanguage4.Items.Add("Japanese")
        LearningLanguage4.Items.Add("Javanese")
        LearningLanguage4.Items.Add("Kannada")
        LearningLanguage4.Items.Add("Kazakh")
        LearningLanguage4.Items.Add("Khmer")
        LearningLanguage4.Items.Add("Korean")
        LearningLanguage4.Items.Add("Kurdish (Kurmanji)")
        LearningLanguage4.Items.Add("Kyrgyz")
        LearningLanguage4.Items.Add("Lao")
        LearningLanguage4.Items.Add("Latin")
        LearningLanguage4.Items.Add("Latvian")
        LearningLanguage4.Items.Add("Lithuanian")
        LearningLanguage4.Items.Add("Luxembourgish")
        LearningLanguage4.Items.Add("Macedonian")
        LearningLanguage4.Items.Add("Malagasy")
        LearningLanguage4.Items.Add("Malay")
        LearningLanguage4.Items.Add("Malayalam")
        LearningLanguage4.Items.Add("Maltese")
        LearningLanguage4.Items.Add("Maori")
        LearningLanguage4.Items.Add("Marathi")
        LearningLanguage4.Items.Add("Mongolian")
        LearningLanguage4.Items.Add("Myanmar (Burmese)")
        LearningLanguage4.Items.Add("Nepali")
        LearningLanguage4.Items.Add("Norwegian")
        LearningLanguage4.Items.Add("Pashto")
        LearningLanguage4.Items.Add("Persian")
        LearningLanguage4.Items.Add("Polish")
        LearningLanguage4.Items.Add("Portuguese")
        LearningLanguage4.Items.Add("Punjabi")
        LearningLanguage4.Items.Add("Romanian")
        LearningLanguage4.Items.Add("Russian")
        LearningLanguage4.Items.Add("Samoan")
        LearningLanguage4.Items.Add("Scots Gaelic")
        LearningLanguage4.Items.Add("Serbian")
        LearningLanguage4.Items.Add("Sesotho")
        LearningLanguage4.Items.Add("Shona")
        LearningLanguage4.Items.Add("Sindhi")
        LearningLanguage4.Items.Add("Sinhala")
        LearningLanguage4.Items.Add("Slovak")
        LearningLanguage4.Items.Add("Slovenian")
        LearningLanguage4.Items.Add("Somali")
        LearningLanguage4.Items.Add("Spanish")
        LearningLanguage4.Items.Add("Sundanese")
        LearningLanguage4.Items.Add("Swahili")
        LearningLanguage4.Items.Add("Swedish")
        LearningLanguage4.Items.Add("Tajik")
        LearningLanguage4.Items.Add("Tamil")
        LearningLanguage4.Items.Add("Telugu")
        LearningLanguage4.Items.Add("Thai")
        LearningLanguage4.Items.Add("Turkish")
        LearningLanguage4.Items.Add("Ukrainian")
        LearningLanguage4.Items.Add("Urdu")
        LearningLanguage4.Items.Add("Uzbek")
        LearningLanguage4.Items.Add("Vietnamese")
        LearningLanguage4.Items.Add("Welsh")
        LearningLanguage4.Items.Add("Xhosa")
        LearningLanguage4.Items.Add("Yiddish")
        LearningLanguage4.Items.Add("Yoruba")
        LearningLanguage4.Items.Add("Zulu")
        LearningLanguage4.SelectedIndex = 0


        LearningLanguage5.Items.Add("")
        LearningLanguage5.Items.Add("English")
        LearningLanguage5.Items.Add("Japanese")
        LearningLanguage5.Items.Add("Afrikaans")
        LearningLanguage5.Items.Add("Albanian")
        LearningLanguage5.Items.Add("Amharic")
        LearningLanguage5.Items.Add("Arabic")
        LearningLanguage5.Items.Add("Armenian")
        LearningLanguage5.Items.Add("Azerbaijani")
        LearningLanguage5.Items.Add("Basque")
        LearningLanguage5.Items.Add("Belarusian")
        LearningLanguage5.Items.Add("Bengali")
        LearningLanguage5.Items.Add("Bosnian")
        LearningLanguage5.Items.Add("Bulgarian")
        LearningLanguage5.Items.Add("Catalan")
        LearningLanguage5.Items.Add("Cebuano")
        LearningLanguage5.Items.Add("Chichewa")
        LearningLanguage5.Items.Add("Chinese")
        LearningLanguage5.Items.Add("Corsican")
        LearningLanguage5.Items.Add("Croatian")
        LearningLanguage5.Items.Add("Czech")
        LearningLanguage5.Items.Add("Danish")
        LearningLanguage5.Items.Add("Dutch")
        LearningLanguage5.Items.Add("English")
        LearningLanguage5.Items.Add("Esperanto")
        LearningLanguage5.Items.Add("Estonian")
        LearningLanguage5.Items.Add("Filipino")
        LearningLanguage5.Items.Add("Finnish")
        LearningLanguage5.Items.Add("French")
        LearningLanguage5.Items.Add("Frisian")
        LearningLanguage5.Items.Add("Galician")
        LearningLanguage5.Items.Add("Georgian")
        LearningLanguage5.Items.Add("German")
        LearningLanguage5.Items.Add("Greek")
        LearningLanguage5.Items.Add("Gujarati")
        LearningLanguage5.Items.Add("Haitian Creole")
        LearningLanguage5.Items.Add("Hausa")
        LearningLanguage5.Items.Add("Hawaiian")
        LearningLanguage5.Items.Add("Hebrew")
        LearningLanguage5.Items.Add("Hindi")
        LearningLanguage5.Items.Add("Hmong")
        LearningLanguage5.Items.Add("Hungarian")
        LearningLanguage5.Items.Add("Icelandic")
        LearningLanguage5.Items.Add("Igbo")
        LearningLanguage5.Items.Add("Indonesian")
        LearningLanguage5.Items.Add("Irish")
        LearningLanguage5.Items.Add("Italian")
        LearningLanguage5.Items.Add("Japanese")
        LearningLanguage5.Items.Add("Javanese")
        LearningLanguage5.Items.Add("Kannada")
        LearningLanguage5.Items.Add("Kazakh")
        LearningLanguage5.Items.Add("Khmer")
        LearningLanguage5.Items.Add("Korean")
        LearningLanguage5.Items.Add("Kurdish (Kurmanji)")
        LearningLanguage5.Items.Add("Kyrgyz")
        LearningLanguage5.Items.Add("Lao")
        LearningLanguage5.Items.Add("Latin")
        LearningLanguage5.Items.Add("Latvian")
        LearningLanguage5.Items.Add("Lithuanian")
        LearningLanguage5.Items.Add("Luxembourgish")
        LearningLanguage5.Items.Add("Macedonian")
        LearningLanguage5.Items.Add("Malagasy")
        LearningLanguage5.Items.Add("Malay")
        LearningLanguage5.Items.Add("Malayalam")
        LearningLanguage5.Items.Add("Maltese")
        LearningLanguage5.Items.Add("Maori")
        LearningLanguage5.Items.Add("Marathi")
        LearningLanguage5.Items.Add("Mongolian")
        LearningLanguage5.Items.Add("Myanmar (Burmese)")
        LearningLanguage5.Items.Add("Nepali")
        LearningLanguage5.Items.Add("Norwegian")
        LearningLanguage5.Items.Add("Pashto")
        LearningLanguage5.Items.Add("Persian")
        LearningLanguage5.Items.Add("Polish")
        LearningLanguage5.Items.Add("Portuguese")
        LearningLanguage5.Items.Add("Punjabi")
        LearningLanguage5.Items.Add("Romanian")
        LearningLanguage5.Items.Add("Russian")
        LearningLanguage5.Items.Add("Samoan")
        LearningLanguage5.Items.Add("Scots Gaelic")
        LearningLanguage5.Items.Add("Serbian")
        LearningLanguage5.Items.Add("Sesotho")
        LearningLanguage5.Items.Add("Shona")
        LearningLanguage5.Items.Add("Sindhi")
        LearningLanguage5.Items.Add("Sinhala")
        LearningLanguage5.Items.Add("Slovak")
        LearningLanguage5.Items.Add("Slovenian")
        LearningLanguage5.Items.Add("Somali")
        LearningLanguage5.Items.Add("Spanish")
        LearningLanguage5.Items.Add("Sundanese")
        LearningLanguage5.Items.Add("Swahili")
        LearningLanguage5.Items.Add("Swedish")
        LearningLanguage5.Items.Add("Tajik")
        LearningLanguage5.Items.Add("Tamil")
        LearningLanguage5.Items.Add("Telugu")
        LearningLanguage5.Items.Add("Thai")
        LearningLanguage5.Items.Add("Turkish")
        LearningLanguage5.Items.Add("Ukrainian")
        LearningLanguage5.Items.Add("Urdu")
        LearningLanguage5.Items.Add("Uzbek")
        LearningLanguage5.Items.Add("Vietnamese")
        LearningLanguage5.Items.Add("Welsh")
        LearningLanguage5.Items.Add("Xhosa")
        LearningLanguage5.Items.Add("Yiddish")
        LearningLanguage5.Items.Add("Yoruba")
        LearningLanguage5.Items.Add("Zulu")
        LearningLanguage5.SelectedIndex = 0


    End Sub

    Private Sub comboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
        If DisplayLanguageCombo.SelectedItem.ToString() = "English" Then
            ChangeLanguage("en")
        Else
            ChangeLanguage("jp-JP")
        End If
    End Sub

    Private Sub ChangeLanguage(ByVal lang As String)
        For Each c As Control In Me.Controls
            Dim resources As ComponentResourceManager = New ComponentResourceManager(GetType(Settings))
            resources.ApplyResources(c, c.Name, New CultureInfo(lang))
        Next c
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles RetypePassword.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles NewPassword.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles OldPassword.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim emptyTextBoxes =
            From txt In Me.Controls.OfType(Of TextBox)()
            Where txt.Text.Length = 0
            Select txt.Name
        If emptyTextBoxes.Any Then
            MessageBox.Show(String.Format("Please fill the following textboxes: {0} ",
                            String.Join(",", emptyTextBoxes)))
        Else
            MsgBox("Settings Changed!")
            Me.Hide()
            FindDecks.Show()
        End If
    End Sub
End Class
