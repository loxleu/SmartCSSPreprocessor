# Smart CSS Preprocessor
Smart CSS Preprocessor (SCP, Smart) is a new CSS preprocessor that makes writing stylesheets easier.
### Another stylesheet preprocessor? Why do I need it?!
Because SCP envolves concepts of other languages like Sass, LESS and Stylus, and has features that other projects don't have. It is moving in two directions. At the one side, it gives more freedom and uses such elements of high-level programming languages like variables, functions, mixins, logical and mathematical operators, conditional constructions, cycles and many more. At the another side, it helps to create complicated interfaces without writing a lot of code - many things are simplified.
### OK, what are you using to develop SCP?
Smart CSS Preprocessor is fully written in C#, and some parts are going to be written in C++. Currently it is available only on Windows, but in the future we will port the compiler to other platforms. We use Visual Studio Community and Visual Studio Code as IDEs.
### How do I compile my Smart code into CSS?
You need to install the compiler from this repository and write a command in the command line. Here is an example of the command
```cmd
C:\Users\Username\> smart FILENAME.smart FILENAME.zip
```
The compiler will put the CSS and the JS files to the zip archive. You will need to bind these files to your document using `<script>` and `<link>` tags respectively. Note that some features might not work without JS - make sure it is bound to the document and JavaScript is enabled in your browser. In addition, there will be an ability to specify a HTML file, and the compiler will add required tags to the document and put the files in a subdirectory!
### Where can I find the docs for the SCP?
You can find description of all elements of Smart's syntax in the repository wiki.
