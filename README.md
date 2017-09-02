# ProtocolBufferUnity
unityでProtocolBuffer使ってデシリアライズ、シリアライズするテスト

# クラスの自動出力

<pre>
protoc -I=./ --csharp_out=./ ./person.proto
</pre>

出力されたPerson.csをUnityProject内に突っ込む

# TODO

- WWWで送信・受信するテスト
