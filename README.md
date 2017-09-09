# ProtocolBufferUnity
unityでProtocolBuffer使ってデシリアライズ、シリアライズするテスト

# クラスの出力

<pre>
protoc -I=./ --csharp_out=./ ./person.proto
</pre>

# Tips

- 配列の定義

<pre>
repeated Person person_list = 1;
</pre>

- 他protoファイルのインポート

以下をsyntaxフィールドの後に記述

<pre>
import "person.proto";
</pre>

# 受信

- www.bytesをPerserに突っ込む

# TODO

- wwwへのPOST
