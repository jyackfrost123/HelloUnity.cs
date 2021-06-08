//© Unity Technologies Japan/UCL
//
//Copyright (c) 2021 jyackfrost123
//This software is released under the MIT License, see LICENSE.

// -------------------------------------------------------------
//空のSceneにHello.Unity.csを置いて世界<ゲーム>をスタートしてね！
//MainCamera の ClearFlags を SolidColor に設定すると見やすいよ！
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// ここまでは歌う準備だよ！さぁ、一緒に歌おう！
// -------------------------------------------------------------

// 「HelloUnity.js」
// 作曲 編曲 : naotyu / 歌 : ユニティちゃん（角元 明日香）

//あてんしょん!この歌<コード>はUnityちゃんバージョン2019以上で歌ってね!
using UnityEngine.UI;

public class HelloUnity_longVer : MonoBehaviour//ココは歌わなくてOKだよ！
{

    Text moji;//Are you ready....?

    //この世界<ゲーム>に生まれたとき それがAwake!
    void Awake(){
        var canvas = gameObject.AddComponent<UnityEngine.Canvas>();//GUI<じーゆーあい>にはこれがないとね!
        canvas.renderMode = RenderMode.ScreenSpaceOverlay;//画面に大きく描いちゃうよ!
        moji = new GameObject().AddComponent<UnityEngine.UI.Text>();//画面に文字を書いちゃうよ!
        var secret = Resources.GetBuiltinResource<Font>("Arial.ttf");//隠しコマンド!秘密だよ!
        moji.font = secret;//文字にフォントを設定だ!
    }

    //この世界<ゲーム>がOnになるとき それがOnEnable!
    void OnEnable(){
        var rect = moji.rectTransform;//まだまだ文字のセッティング！
        rect.SetParent(gameObject.transform);//画面と文字を合体だ！
        rect.localPosition =  Vector3.zero;//文字の位置をリセットしよう！
        rect.sizeDelta = new Vector2(Screen.width, Screen.height);//画面と大きさをそろえるよ！
    }

    //この世界<ゲーム>が始まるとき それがStart!
    void Start(){
        moji.fontSize = 128;//フォントは大きく設定だ!
        moji.alignment = TextAnchor.MiddleCenter;//文字はでっかく中央に!
        moji.text = "Hello, Unity!!";//これで準備は万全だ!
    }

    //この世界<ゲーム>が躍動するとき それがUpdate!
    void Update(){
        var v = Mathf.Sin(Time.time);//うごきの秘密は三角関数!
        moji.transform.rotation =  Quaternion.Euler(0, 0, v * 360);//画面のまんなか グルグル回るよ!
        var go = (1+v);//秘密の値でスケールだ!
        moji.transform.localScale = new Vector3(go, go, go);//さぁ実行してみよう!
    }

}
