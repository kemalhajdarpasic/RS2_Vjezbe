import 'package:flutter/material.dart';

void main() {
  runApp(const MyMatirialApp());
}

class MyApp extends StatelessWidget {
  const MyApp({super.key});

  // This widget is the root of your application.
  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      title: 'Flutter Demo',
      theme: ThemeData(
        // This is the theme of your application.
        //
        // TRY THIS: Try running your application with "flutter run". You'll see
        // the application has a purple toolbar. Then, without quitting the app,
        // try changing the seedColor in the colorScheme below to Colors.green
        // and then invoke "hot reload" (save your changes or press the "hot
        // reload" button in a Flutter-supported IDE, or press "r" if you used
        // the command line to start the app).
        //
        // Notice that the counter didn't reset back to zero; the application
        // state is not lost during the reload. To reset the state, use hot
        // restart instead.
        //
        // This works for code too, not just values: Most code changes can be
        // tested with just a hot reload.
        colorScheme: ColorScheme.fromSeed(seedColor: Colors.blue),
        useMaterial3: true,
      ),
      home: LayoutExamples(),
    );
  }
}

class MyAppBar extends StatelessWidget {
  String title;
  MyAppBar({super.key, required this.title});

  @override
  Widget build(BuildContext context) {
    return Text(title);
  }
}

class Counter extends StatefulWidget {
  const Counter({super.key});

  @override
  State<Counter> createState() => _CounterState();
}

class _CounterState extends State<Counter> {

  int _count = 0;

  void _incrementCounter(){
    setState(() {  
    _count++;
    });
  }

  @override
  Widget build(BuildContext context) {
    return Column(
      children: [
        Text("You have pushed button $_count times"),
        ElevatedButton(onPressed: _incrementCounter, child: Text("Increment++"))
      ],
    );
  }
}
 
class LayoutExamples extends StatelessWidget {
  const LayoutExamples({super.key});

  @override
  Widget build(BuildContext context) {
    return Column(
      children: [
        Container(
          height: 100,
          color: Colors.lightGreen,
          child: Text("Example text"),
          alignment: Alignment.center,
        ),
        Row(
          mainAxisAlignment: MainAxisAlignment.spaceAround,
          children: [
            Text("Item 1"),
            Text("Item 2"),
            Text("Item 3")
          ],
        )
      ],
    );
  }
}

class MyMatirialApp extends StatelessWidget {
  const MyMatirialApp({super.key});

  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      title: "RS2 Material app",
      theme: ThemeData(
        primarySwatch: Colors.blue,
        colorScheme: ColorScheme.fromSeed(seedColor: Colors.blue),
        useMaterial3: true,
        ),
      home: LoginPage(),
    );
  }
}

class LoginPage extends StatelessWidget {
  const LoginPage({super.key});

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        backgroundColor: Colors.blue,
        title: Text("Login"),
      ),
      body: Center(
        child: Container(
          constraints: BoxConstraints(maxWidth: 400, maxHeight: 400),
          child: Card(
            child: Padding(
              padding: const EdgeInsets.all(16.0),
              child: Column(
                children: [
                  Image.network("https://www.fit.ba/content/763cbb87-718d-4eca-a991-343858daf424"),
                  TextField(
                    decoration: InputDecoration(
                      labelText: "Username",
                      prefixIcon: Icon(Icons.email)
                    ),
                  ),
                  SizedBox(height: 8,),
                  TextField(
                    decoration: InputDecoration(
                      labelText: "Password",
                      prefixIcon: Icon(Icons.password)
                    ),
                  ),
                  SizedBox(height: 8,),
                  ElevatedButton(onPressed:() {
                    
                  }, child: Text("Login"))
                ],
              ),
            ),
          ),
        )
      ),
    );
  }
}