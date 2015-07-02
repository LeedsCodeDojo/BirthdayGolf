let rec s=function 1->1|n when n%2=0->1+s(n/2)|n->1+s(3*n+1)
[<EntryPoint>]let main n=printf"%i"(s(int n.[0]));0