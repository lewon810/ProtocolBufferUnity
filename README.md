# ProtocolBufferUnity
unityでProtocolBuffer使ってデシリアライズ、シリアライズするテスト

# クラスの自動出力

<pre>
protoc -I=./ --csharp_out=./ ./person.proto
</pre>

出力されたソースコードをUnityProject内に突っ込む
