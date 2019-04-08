﻿using StraySouls.Wrapper;

namespace StraySouls
{
    public class EnemyRandomProperties : IRandomProperties<EnemyWrapper>
    {
        private string _modelName;

        private int _talkID;

        private int _NPCParamID;

        private int _charaInitID;

        private int _thinkParamID;

        private int _eventEntityID;

        public EnemyRandomProperties() { }

        public EnemyRandomProperties(EnemyWrapper enemy)
        {
            RecordProperty(enemy);
        }

        public void RecordProperty(EnemyWrapper enemy)
        {
            _modelName = enemy.ModelName;
            _NPCParamID = enemy.NPCParamID;
            _thinkParamID = enemy.ThinkParamID;
            _eventEntityID = enemy.EventEntityID;
            _charaInitID = enemy.CharaInitID;
            _talkID = enemy.TalkID;
        }

        public void ApplyToEntry(EnemyWrapper enemy)
        {
            enemy.ModelName = _modelName;
            enemy.NPCParamID = _NPCParamID;
            enemy.ThinkParamID = _thinkParamID;
            enemy.EventEntityID = _eventEntityID;
            enemy.CharaInitID = _charaInitID;
            enemy.TalkID = _talkID;
        }
    }
}
