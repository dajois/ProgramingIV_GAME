#GENSYAの書いたやつ
- コイン落としゲーム
 - Unity tutorial
 - というかこれはただのテスト
 - fetch と merge できるか確認したかった

- iOS 実機テストの仕方
1.Unityを開く  
2.File → Open Scece... からProject起動  
3.File → Build Settings... でBuildの設定ができる  
4.Platform で iOS を選択し, Switch Platform を実行 (初回はpkgのダウンロードがあったかも)  
5.Buildを実行 (任意の名前をつけ保存)  
6.Xcodeを起動し, Buildしたファイルを読み込む  
7.iPhone と PC を同期させる (USBケーブルなどで)  
8.Xcode の実機テストの欄の Device に 同期した iPhone が選べるようになるので選択  
9.Xcode から作成した Project の General からBundle Identifier Version Team を各自設定 (iPhone の ver が 10 以上なら MacOS を Sierra にしないと動かないかも)  
10.その後 Xcode の Run (再生マーク) を選択 (初回に限り起動まで時間がかかることと, 安全面の確認のため iPhone の設定で認証しないと動かなかったはず)
