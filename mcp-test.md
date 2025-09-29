# MCP Server Configuration Guide

## filesystem MCPサーバーの正しい設定

### 1. 前提条件
- Node.js がインストールされていること
- `@modelcontextprotocol/server-filesystem` パッケージがインストールされていること

### 2. インストール方法
```bash
cd C:\mcp-servers
npm init -y
npm install @modelcontextprotocol/server-filesystem
```

### 3. DiRAG での設定

#### Option 1: 直接実行（推奨）
- **Name:** filesystem
- **Command:** `node` または `C:\Program Files\nodejs\node.exe`
- **Arguments:** `node_modules\@modelcontextprotocol\server-filesystem\dist\index.js C:/Users/user_name/Documents`
- **Working Directory:** `C:\mcp-servers`
- **Transport Type:** Stdio
- **Enabled:** ✓

#### Option 2: npxを使用
- **Name:** filesystem
- **Command:** `npx`
- **Arguments:** `-y @modelcontextprotocol/server-filesystem C:/Users/user_name/Documents`
- **Working Directory:** `C:\mcp-servers`
- **Transport Type:** Stdio
- **Enabled:** ✓

### 4. トラブルシューティング

#### タイムアウトエラーが発生する場合
1. Node.jsのパスが正しいか確認
2. Working Directory が正しく設定されているか確認
3. MCPサーバーのログを確認

#### 接続できない場合
1. コマンドプロンプトで以下を実行して動作確認:
   ```bash
   cd C:\mcp-servers
   node node_modules\@modelcontextprotocol\server-filesystem\dist\index.js C:/Users/user_name/Documents
   ```
   正常なら「Secure MCP Filesystem Server running on stdio」と表示される

2. ファイアウォールやアンチウイルスソフトがNode.jsをブロックしていないか確認

### 5. 利用可能なツール
filesystemサーバーは以下のツールを提供します:
- `read_file` - ファイルの内容を読み取る
- `read_multiple_files` - 複数のファイルを一度に読み取る
- `write_file` - ファイルに書き込む
- `create_directory` - ディレクトリを作成
- `list_directory` - ディレクトリの内容を一覧表示
- `move_file` - ファイルを移動/リネーム
- `search_files` - ファイルを検索
- `get_file_info` - ファイル情報を取得
- `list_allowed_directories` - アクセス可能なディレクトリを表示

### 6. セキュリティノート
- Arguments で指定したディレクトリのみアクセス可能
- 複数のディレクトリへのアクセスを許可する場合は、スペース区切りで指定
  例: `node_modules\...\index.js C:/Users/user_name/Documents C:/Users/user_name/Projects`