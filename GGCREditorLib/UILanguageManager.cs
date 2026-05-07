using System;
using System.Globalization;
using System.Threading;

namespace GGCREditor
{
    public class UILanguageManager
    {
        private static string _uiLanguage = "english";
        private static string _gameLanguage = "schinese";
        private static bool _linkLanguages = true;
        private static bool _initialized = false;

        public static event EventHandler LanguageChanged;

        public static string[] SupportedLanguages = new string[] {
            "english",
            "schinese",
            "tchinese/hk",
            "tchinese/tw",
            "japanese",
            "korean"
        };

        public static string[] SupportedLanguageDisplayNames = new string[] {
            "English",
            "简体中文",
            "繁体中文-香港",
            "繁体中文-台湾",
            "日本語",
            "한국어"
        };

        public static void Initialize()
        {
            if (_initialized) return;
            StringResources.Initialize();
            _initialized = true;
        }

        public static string UILanguage
        {
            get { return _uiLanguage; }
            set
            {
                if (_uiLanguage != value && !string.IsNullOrEmpty(value))
                {
                    _uiLanguage = value;
                    StringResources.SetLanguage(value);
                    OnLanguageChanged();
                }
            }
        }

        public static string GameLanguage
        {
            get { return _gameLanguage; }
            set
            {
                if (_gameLanguage != value && !string.IsNullOrEmpty(value))
                {
                    _gameLanguage = value;
                    GGCRStaticConfig.Language = value;
                    OnLanguageChanged();
                }
            }
        }

        public static bool LinkLanguages
        {
            get { return _linkLanguages; }
            set { _linkLanguages = value; }
        }

        public static string GetDefaultUILanguage()
        {
            CultureInfo currentCulture = Thread.CurrentThread.CurrentUICulture;
            string cultureName = currentCulture.Name.ToLower();

            if (cultureName.StartsWith("zh-hk") || cultureName.StartsWith("zh-tw"))
            {
                return "tchinese/tw";
            }
            if (cultureName.StartsWith("zh"))
            {
                return "schinese";
            }
            if (cultureName.StartsWith("ja"))
            {
                return "japanese";
            }
            if (cultureName.StartsWith("ko"))
            {
                return "korean";
            }

            return "english";
        }

        public static void SetUILanguage(string code)
        {
            UILanguage = code;

            if (_linkLanguages)
            {
                GameLanguage = code;
            }
        }

        public static void SetGameLanguage(string code)
        {
            GameLanguage = code;

            if (_linkLanguages)
            {
                UILanguage = code;
            }
        }

        public static void SetLinkLanguages(bool link)
        {
            _linkLanguages = link;
            OnLanguageChanged();
        }

        public static int GetLanguageIndex(string code)
        {
            for (int i = 0; i < SupportedLanguages.Length; i++)
            {
                if (SupportedLanguages[i] == code)
                    return i;
            }
            return 0;
        }

        private static void OnLanguageChanged()
        {
            if (LanguageChanged != null)
            {
                LanguageChanged(null, EventArgs.Empty);
            }
        }
    }
}