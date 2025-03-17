# A->B : 5  A<-B : 3    A>B == A<-B +1
#  A<-B == A->B ? Compare PrIndex()
# A<->B == AND Compare PrIndex equal?   No Give & Take
# def compareGnT(a,b,atob, btoa):
#     if(atob>btoa):
#         return b #b가 줘야함
#     return a

# def comparePrIndex(a,b, indexa,indexb):
#     return a    

def solution(friends, gifts):
    #이름이 같은 friends는 없음
    #gifts는 공백으로 Split하여 A B -> AtoB를 의미
    dict_prindex = {}
    gifted={}

    for i in range(len(friends)):   # 선물지수 초기화
        gifted[friends[i]]={}           # 이중 dict
        dict_prindex[friends[i]]= 0
    
    
    for j in range(len(gifts)):     # 선물지수 값 넣기 & 
        t,f = gifts[j].split(' ')   # a->b 선물

        if f in gifted[t]:
            gifted[t][f]+=1 #준적 있으면 추가
        else:
            gifted[t][f]=1  #처음이면 1 초기화

        dict_prindex[t] +=1 #주면 +1
        dict_prindex[f] -=1 #받으면 -1

    #각각 받게될 선물 수 
    will_get = [0 for _ in friends] #freind 순서대로 초기화

    for i in range(len(friends)):
        curr=friends[i]
        for j in range(i+1, len(friends)):
            other = friends[j]
            a= gifted[curr][other] if other in gifted[curr] else 0  # curr->other 준적 있으면 값(선물개수) (dict에 있는지) 없으면 0
            b=  gifted[other][curr] if curr in gifted[other] else 0 # other->curr 준 선물 개수

            if a>b:
                will_get[i] +=1
            elif a<b:
                will_get[j] +=1
            elif a==b:             #주고 받은 개수가 같으면 선물지수를 비교
                indexa = dict_prindex[curr]
                indexb = dict_prindex[other]
                if indexa > indexb:
                    will_get[i] +=1
                elif indexa < indexb:
                    will_get[j] +=1
    answer = max(will_get)
    return answer


#solution(["a", "b", "c"],["a b", "b a", "c a", "a c", "a c", "c a"])