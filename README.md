# HelloUnity.cs
Unity-chan!様の『HelloUnity.js』という曲の二次創作、
JavaScriptの原曲をC#にアレンジした『HelloUnity.cs』です

## このプロジェクトの説明
このプロジェクトは、Unity-chan!公式様で頒布されている『キャラクターソング・アルバム Vol.1「UNITE IN THE SKY」』の収録曲、
『HelloUnity.js』について、JavaScriptで作成された歌詞を、C#スクリプトで記述しなおしたものです。

記述しなおすにあたり、歌詞をC#で再翻訳した『HelloUnity.cs』と、
変更点を吸収するために、『幻の2番 onEnable』という体で追記部分をonEnableに追加した、
『HelloUnity_longVer.cs』の2バージョンがあります。
(変更に当たっての詳細は後述します)

どちらも基本的な部分は原曲のまま作成し、
一部はC#に置き換えたスクリプトに若干の変更を加えています。

また、実際に実行して動作を確認できるようSampleSceneとPrefubも実装しています。

## 動作条件
Unity2019以降のUnity実行環境にて、このUnityプロジェクトを開いてください。

## ファイル構成
　・Prefubs：HelloUnityとHellowUnity_longVerがすでについているPrefubが格納されています。
 
　　　　　　 実行結果はどちらもほぼ変わりません。お好きな方をSceneに設置してゲームを実行すると、
       
       
 　　　　　　HelloUnity.csの実行結果が確認できます。

　・Scenes：SampleSceneには、すでにHelloUnity.csがついているPrefubが置いてあります。
 
　　　　　　ゲームを実行すると、HelloUnity.csの実行結果が確認できます。

　・Scripts:『HelloUnity.cs』と『HelloUnity_longVer.cs』の2種類のスクリプトが入っています。
 
 　　　　　　どちらも原曲歌詞に合わせてコメントが入っています。コメント通り好きに歌って下さい。
       
  　　　　　　ちなみに『HelloUnity.js』の元歌詞・音源・カラオケ音源などにつきましては、
        
  　　　　　　[unity-chan!公式HP](https://unity-chan.com/)で配布されておりますので、そちらをご参照ください。


## ライセンス・免責

Copyright (c) 2021 jyackfrost123
This software is released under the MIT License, see LICENSE, see LICENSE.
This website content is released under the CC BY 4.0 License, see LICENSE.


また、本ソースコードは、Unity-chan!公式様の二次創作として、
ユニティ・テクノロジーズ・ジャパン株式会社様のユニティちゃんライセンス条項[https://unity-chan.com/contents/guideline/]を確認し、
同意したうえで作成しています。
もしこのプログラムが他人の権利・名誉を棄損する場合や、
ユニティ・テクノロジーズ・ジャパン株式会社様やUnity-chan!公式様を傷つけるようなことがある際には、
理由なくの公開中止いたしますのでご了承ください。

また、このソースコードについて何か問題がある場合や、
気になる点などがありましたら、jyackfrost123@gmail.comまでご連絡下さい。

## 作者

[jyackfrost123](https://github.com/jyackfrost123)

