========== ========== ==========
  『HelloUnity.cs』  ver.1.0
========== ========== ==========

【 プロジェクト名 】HelloUnity.cs
【 製 作 者 】jyackfrost123(GitHub)
【  種  別  】Unityプロジェクト
【 開発環境 】Unity 2019.4.15f1
【 動作環境 】Unity 2019以降
【バージョン】1.0
【最終更新日】2021/06/09
【 E - mail 】jyackfrost123@gmail.com

---------- ----------
◇ 概要 ◇
このプロジェクトは、Unity-chan!公式様で頒布されている『キャラクターソング・アルバム Vol.1「UNITE IN THE SKY」』の収録曲、
『HelloUnity.js』について、JavaScriptで作成された歌詞を、C#スクリプトで記述しなおしたものです。

記述しなおすにあたり、歌詞をC#で再翻訳した『HelloUnity.cs』と、
変更点を吸収するために、『幻の2番 onEnable』という体で追記部分をonEnableに追加した、
『HelloUnity_longVer.cs』の2バージョンがあります。
(変更に当たっての詳細は後述します)

どちらも基本的な部分は原曲のまま作成し、
一部はC#に置き換えたスクリプトに若干の変更を加えています。

また、実際に実行して動作を確認できるようSampleSceneとPrefubも実装しています。



◇ C#への変更に当たっての詳細事項(内容解説) ◇

今回の実装に当たって、原曲の『HelloUnity.js』通りに実装をした際、大きく変更があった点があります。
近年のUnityではRenderModeをScreenSpaceOverlayにすると、Canvasが"Some values Driven by Canvas." という状態になり、
CanvasがrotationやlocalScaleの変更を受け付けなくなる仕様になっています。

そのため、HelloUnity.csのついているGameObjectの子オブジェクトとしてTextを作成し、
子オブジェクトの位置を調整し、大きさを変更することで動きを実装しています。

しかし、その際に既存の歌詞からできるだけ歌詞を崩さぬよう実装が必要となり、
自身の力量で理想の動きをするために、Scriptの内容も無理やりな実装となってしまいました。

そこで、原曲の雰囲気を壊さないよう考えた結果、
まず、『追記部分はコメントアウト』で元の歌詞を崩さない『HelloUnity.cs』を作成しました。
その後、『幻の2番 onEnable』という体でAwake,Start,Updateの内容はそのまま、追記部分をonEnableに追加した、
『HelloUnity_longVer.cs』の２種類を作成いたしました。

正直、sizeDeltaの指定にかかわるScreenサイズの取得方法や、
そもそもの大きな書き換えが必要である、自身のプログラミング能力の稚拙さが目立ちますので、
プログラム内容は、ダウンロードいただいたみなさまに更新いただいて結構です。



◇ 動作条件 ◇
Unity2019以降のUnity実行環境にて、このUnityプロジェクトを開いてください。



◇ ファイル構成 ◇

　・Prefubs：HelloUnityとHellowUnity_longVerがすでについているPrefubが格納されています。
　　　　　　 実行結果はどちらもほぼ変わりません。お好きな方をSceneに設置してゲームを実行すると、
　　　　　　 HelloUnity.csの実行結果が確認できます。

　・Scenes：SampleSceneには、すでにHelloUnity.csがついているPrefubが置いてあります。
　　　　　　ゲームを実行すると、
　　　　　　HelloUnity.csの実行結果が確認できます。

　・Scripts:HelloUnity.csとHelloUnity_longVer.csが入っています。
　　　　　　どちらも原曲歌詞に合わせてコメントが入っています。
　　　　　　コメントの指示通り好きに歌って下さい。
　　　　　　ちなみに『HelloUnity.js』の元歌詞・音源・カラオケ音源などにつきましては、
　　　　　　unity-chan!公式HP(URL: https://unity-chan.com/)で配布されておりますので、
　　　　　　そちらをご利用ください。



◇ 免責 ◇
本ソースコードは、Unity-chan!公式様の二次創作として、
ユニティ・テクノロジーズ・ジャパン株式会社様のユニティちゃんライセンス条項を確認し、
同意したうえで作成しています。
もしこのプログラムが他人の権利・名誉を棄損する場合や、
ユニティ・テクノロジーズ・ジャパン株式会社様やUnity-chan!公式様を傷つけるようなことがある際には、
理由なくの公開中止いたしますのでご了承ください。

また、このソースコードについて何か問題がある場合や、
気になる点などがありましたら、jyackfrost123@gmail.comまでご連絡下さい。



----------
◇ 連絡先 ◇
	E-mail : jyackfrost123@gmail.com



◇ 履歴 ◇
2021/06/09 HelloUnity.cs を作成、GitHubに公開


