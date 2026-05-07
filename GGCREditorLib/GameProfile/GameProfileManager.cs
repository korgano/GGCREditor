using System;
using System.Collections.Generic;

namespace GGCREditorLib.GameProfile
{
    public class GameProfileManager
    {
        private static GameProfileManager _instance;
        private static readonly object _lock = new object();

        private List<IGGCGameProfile> _profiles;
        private IGGCGameProfile _activeProfile;
        private IGGCGameProfile _defaultProfile;

        private GameProfileManager()
        {
            _profiles = new List<IGGCGameProfile>();
            LoadProfiles();
        }

        public static GameProfileManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new GameProfileManager();
                        }
                    }
                }
                return _instance;
            }
        }

        private void LoadProfiles()
        {
            _profiles = ProfileLoader.LoadAllProfiles();

            foreach (IGGCGameProfile profile in _profiles)
            {
                if (profile.GameId == "cross_rays")
                {
                    _defaultProfile = profile;
                    break;
                }
            }

            if (_defaultProfile == null && _profiles.Count > 0)
            {
                _defaultProfile = _profiles[0];
            }
        }

        public List<IGGCGameProfile> GetAllProfiles()
        {
            return _profiles;
        }

        public IGGCGameProfile GetDefaultProfile()
        {
            return _defaultProfile;
        }

        public IGGCGameProfile GetActiveProfile()
        {
            return _activeProfile ?? _defaultProfile;
        }

        public void SetActiveProfile(IGGCGameProfile profile)
        {
            if (profile != null)
            {
                _activeProfile = profile;
            }
        }

        public void SetActiveProfileById(string gameId)
        {
            foreach (IGGCGameProfile profile in _profiles)
            {
                if (profile.GameId == gameId)
                {
                    _activeProfile = profile;
                    return;
                }
            }
        }

        public void ClearActiveProfile()
        {
            _activeProfile = null;
        }

        public void SetProfilePath(string path)
        {
            if (_activeProfile != null)
            {
                _activeProfile.GamePath = path;
            }
            else if (_defaultProfile != null)
            {
                _defaultProfile.GamePath = path;
            }
        }

        public IGGCGameProfile FindProfileById(string gameId)
        {
            foreach (IGGCGameProfile profile in _profiles)
            {
                if (profile.GameId == gameId)
                {
                    return profile;
                }
            }
            return null;
        }
    }
}