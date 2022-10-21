void StackNoParams(){
    int a = 4;
    int b = 5;
    int c = 6;
    int d = 7;
    int e = 8;
}

void StackWithParams(int a, int b, int c){
    int d = a + b + c;
}

void StackWithHeap(int a, int b, int c, string d){
    int e = 4;
    int f = 5;
    string g = "Hello World";
}

void StackOver(){
    for(int x=0; x<1000; x++){
        StackOver();
    }
}

StackNoParams();
StackWithParams(1,2,3);
StackWithHeap(1,2,3,"Hello World");
StackOver();