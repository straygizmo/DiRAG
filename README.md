# DiRAG - One of the easiest ways to chat with directories

DiRAG is a Windows desktop application that provides an AI chat interface enhanced with Retrieval-Augmented Generation (RAG) capabilities. It allows you to have conversations with AI models while providing relevant context from your local documents and folders.

## Features

- **Multi-Provider Support**: Works with OpenAI-compatible APIs, Claude Code CLI, and custom providers
- **RAG Integration**: Automatically processes and indexes documents from selected folders to provide contextual information
- **Blazor WebView UI**: Modern web-based chat interface within a Windows Forms application
- **Document Processing**: Converts various document formats to markdown for better context understanding
- **Configurable Settings**: Customize API endpoints, models, embedding settings, and more
- **Folder Selection**: Choose specific directories to include in your knowledge base

## Prerequisites

- Windows 10 or later
- .NET 9.0 Runtime or SDK
- Visual Studio 2022 (for building from source)
- Python 3.x
- uv

## Installation

### Build from Source

1. Clone the repository:
```bash
git clone https://github.com/straygizmo/DiRAG.git
cd DiRAG
```

2. Open `DiRAG.sln` in Visual Studio 2022

3. Restore NuGet packages (Visual Studio should do this automatically)

4. Build the solution (F6 or Build → Build Solution)

5. Run the application (F5 or Debug → Start Debugging)

## Configuration

On first launch, DiRAG will prompt you to configure your API settings. You can also access settings anytime through the application menu.

### API Provider Configuration

DiRAG supports multiple API providers:

#### OpenAI-Compatible APIs
- **Base URL**: Your API endpoint (e.g., `http://localhost:1234` for LM Studio)
- **API Key**: Your authentication key
- **Model**: The model to use (e.g., `gpt-4o`)

#### Claude Code CLI
- **CLI Path**: Path to Claude Code executable
- **Model**: Claude model identifier

### Embedding Configuration

For RAG functionality, configure embedding settings:
- **Embedding URL**: Endpoint for generating embeddings (e.g., `http://localhost:1234` for LM Studio)
- **Embedding Model**: Model for embeddings (e.g., `text-embedding-embeddinggemma-300m`)

### RAG Settings
- **Context Length**: Maximum context window size
- **Chunk Size**: Size of document chunks for processing
- **Chunk Overlap**: Overlap between consecutive chunks

## Usage

1. **Launch the Application**: Run `DiRAG.exe`

2. **Select Folders**: Use the folder tree on the left to select directories containing documents you want to include in your knowledge base

3. **Process Documents**: The application will automatically process and index documents from selected folders

4. **Start Chatting**: Type your questions in the chat interface. The AI will use both its training and the context from your documents to provide answers

5. **View Context**: Click the "Context" button to see what document chunks are being used for the current conversation

## Project Structure

```
DiRAG/
├── DiRAG/                      # Main application project
│   ├── Forms/                  # Windows Forms UI components
│   ├── Pages/                  # Blazor components
│   ├── Services/               # Business logic and services
│   │   ├── IChatService.cs     # Chat service interface
│   │   ├── IRagService.cs      # RAG service interface
│   │   ├── OpenAIChatService.cs
│   │   ├── ClaudeCodeChatService.cs
│   │   └── RagService.cs       # RAG implementation
│   ├── Models/                 # Data models
│   └── wwwroot/               # Web assets for Blazor
├── python_tools/              # Python utilities
│   └── convert_to_markdown.py # Document conversion tool
└── DiRAG.sln                  # Visual Studio solution file
```

## Building from Source

### Requirements
- Visual Studio 2022 with .NET desktop development workload
- .NET 9.0 SDK

### Build Steps
1. Clone the repository
2. Open `DiRAG.sln` in Visual Studio
3. Restore NuGet packages
4. Build the solution (Release configuration for production)
5. Output will be in `DiRAG\bin\Release\net9.0-windows\`

## Python Tools Setup (Required)

Python tools are **required** for document processing, chunking, and embedding functionality. DiRAG uses Python for:
- Document conversion (MarkItDown)
- Text chunking and processing
- Embedding generation

### Setup Instructions

1. Navigate to the python_tools directory:
```bash
cd python_tools
```

2. Install dependencies using uv:
```bash
uv sync
```

This will install all necessary Python dependencies including:
- MarkItDown for document conversion (PDF, DOCX, etc.)
- Libraries for text chunking
- Embedding generation utilities

**Note**: Without proper Python tools setup, RAG functionality will not work correctly.

## Contributing

Contributions are welcome! Please feel free to submit pull requests or open issues for bugs and feature requests.

## Troubleshooting

### Common Issues

1. **API Configuration Required**: Ensure you've configured at least one API provider in Settings
2. **Document Processing Fails**: Check that selected folders are accessible and contain supported file formats
3. **Embedding Errors**: Verify embedding API credentials and endpoint configuration

### Supported File Formats
- Text files (.txt, .md, .csv)
- Code files (.cs, .js, .py, .json, etc.)
- Documents (.pdf, .docx with python_tools installed)
- Web files (.html, .xml)

## License

MIT

## Acknowledgments

- Built with [Blazor WebView](https://docs.microsoft.com/en-us/aspnet/core/blazor/hybrid/)
- UI components from [Krypton Toolkit](https://github.com/Krypton-Suite/Standard-Toolkit)
- OpenAI integration using [OpenAI-DotNet](https://github.com/RageAgainstThePixel/OpenAI-DotNet)
- Document processing with [MarkItDown](https://github.com/microsoft/markitdown)
