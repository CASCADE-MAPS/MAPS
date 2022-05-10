#include "pch-c.h"
#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif


#include "codegen/il2cpp-codegen-metadata.h"





// 0x00000001 System.Exception System.Linq.Error::ArgumentNull(System.String)
extern void Error_ArgumentNull_m0EDA0D46D72CA692518E3E2EB75B48044D8FD41E (void);
// 0x00000002 System.Exception System.Linq.Error::MoreThanOneMatch()
extern void Error_MoreThanOneMatch_m4C4756AF34A76EF12F3B2B6D8C78DE547F0FBCF8 (void);
// 0x00000003 System.Exception System.Linq.Error::NoElements()
extern void Error_NoElements_mB89E91246572F009281D79730950808F17C3F353 (void);
// 0x00000004 System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable::Where(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,System.Boolean>)
// 0x00000005 System.Func`2<TSource,System.Boolean> System.Linq.Enumerable::CombinePredicates(System.Func`2<TSource,System.Boolean>,System.Func`2<TSource,System.Boolean>)
// 0x00000006 System.Linq.IOrderedEnumerable`1<TSource> System.Linq.Enumerable::OrderBy(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,TKey>)
// 0x00000007 System.Linq.IOrderedEnumerable`1<TSource> System.Linq.Enumerable::ThenBy(System.Linq.IOrderedEnumerable`1<TSource>,System.Func`2<TSource,TKey>)
// 0x00000008 TSource[] System.Linq.Enumerable::ToArray(System.Collections.Generic.IEnumerable`1<TSource>)
// 0x00000009 System.Collections.Generic.List`1<TSource> System.Linq.Enumerable::ToList(System.Collections.Generic.IEnumerable`1<TSource>)
// 0x0000000A TSource System.Linq.Enumerable::First(System.Collections.Generic.IEnumerable`1<TSource>)
// 0x0000000B TSource System.Linq.Enumerable::Last(System.Collections.Generic.IEnumerable`1<TSource>)
// 0x0000000C TSource System.Linq.Enumerable::SingleOrDefault(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,System.Boolean>)
// 0x0000000D System.Boolean System.Linq.Enumerable::Any(System.Collections.Generic.IEnumerable`1<TSource>)
// 0x0000000E System.Boolean System.Linq.Enumerable::Any(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,System.Boolean>)
// 0x0000000F System.Int32 System.Linq.Enumerable::Count(System.Collections.Generic.IEnumerable`1<TSource>)
// 0x00000010 System.Boolean System.Linq.Enumerable::Contains(System.Collections.Generic.IEnumerable`1<TSource>,TSource)
// 0x00000011 System.Boolean System.Linq.Enumerable::Contains(System.Collections.Generic.IEnumerable`1<TSource>,TSource,System.Collections.Generic.IEqualityComparer`1<TSource>)
// 0x00000012 System.Int32 System.Linq.Enumerable::Sum(System.Collections.Generic.IEnumerable`1<System.Int32>)
extern void Enumerable_Sum_m6CFC8CEAC70AE3C469A5D1993FAF8EEEC6A06FB5 (void);
// 0x00000013 System.Void System.Linq.Enumerable/Iterator`1::.ctor()
// 0x00000014 TSource System.Linq.Enumerable/Iterator`1::get_Current()
// 0x00000015 System.Linq.Enumerable/Iterator`1<TSource> System.Linq.Enumerable/Iterator`1::Clone()
// 0x00000016 System.Void System.Linq.Enumerable/Iterator`1::Dispose()
// 0x00000017 System.Collections.Generic.IEnumerator`1<TSource> System.Linq.Enumerable/Iterator`1::GetEnumerator()
// 0x00000018 System.Boolean System.Linq.Enumerable/Iterator`1::MoveNext()
// 0x00000019 System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable/Iterator`1::Where(System.Func`2<TSource,System.Boolean>)
// 0x0000001A System.Object System.Linq.Enumerable/Iterator`1::System.Collections.IEnumerator.get_Current()
// 0x0000001B System.Collections.IEnumerator System.Linq.Enumerable/Iterator`1::System.Collections.IEnumerable.GetEnumerator()
// 0x0000001C System.Void System.Linq.Enumerable/Iterator`1::System.Collections.IEnumerator.Reset()
// 0x0000001D System.Void System.Linq.Enumerable/WhereEnumerableIterator`1::.ctor(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,System.Boolean>)
// 0x0000001E System.Linq.Enumerable/Iterator`1<TSource> System.Linq.Enumerable/WhereEnumerableIterator`1::Clone()
// 0x0000001F System.Void System.Linq.Enumerable/WhereEnumerableIterator`1::Dispose()
// 0x00000020 System.Boolean System.Linq.Enumerable/WhereEnumerableIterator`1::MoveNext()
// 0x00000021 System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable/WhereEnumerableIterator`1::Where(System.Func`2<TSource,System.Boolean>)
// 0x00000022 System.Void System.Linq.Enumerable/WhereArrayIterator`1::.ctor(TSource[],System.Func`2<TSource,System.Boolean>)
// 0x00000023 System.Linq.Enumerable/Iterator`1<TSource> System.Linq.Enumerable/WhereArrayIterator`1::Clone()
// 0x00000024 System.Boolean System.Linq.Enumerable/WhereArrayIterator`1::MoveNext()
// 0x00000025 System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable/WhereArrayIterator`1::Where(System.Func`2<TSource,System.Boolean>)
// 0x00000026 System.Void System.Linq.Enumerable/WhereListIterator`1::.ctor(System.Collections.Generic.List`1<TSource>,System.Func`2<TSource,System.Boolean>)
// 0x00000027 System.Linq.Enumerable/Iterator`1<TSource> System.Linq.Enumerable/WhereListIterator`1::Clone()
// 0x00000028 System.Boolean System.Linq.Enumerable/WhereListIterator`1::MoveNext()
// 0x00000029 System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable/WhereListIterator`1::Where(System.Func`2<TSource,System.Boolean>)
// 0x0000002A System.Void System.Linq.Enumerable/<>c__DisplayClass6_0`1::.ctor()
// 0x0000002B System.Boolean System.Linq.Enumerable/<>c__DisplayClass6_0`1::<CombinePredicates>b__0(TSource)
// 0x0000002C System.Linq.IOrderedEnumerable`1<TElement> System.Linq.IOrderedEnumerable`1::CreateOrderedEnumerable(System.Func`2<TElement,TKey>,System.Collections.Generic.IComparer`1<TKey>,System.Boolean)
// 0x0000002D System.Collections.Generic.IEnumerator`1<TElement> System.Linq.OrderedEnumerable`1::GetEnumerator()
// 0x0000002E System.Linq.EnumerableSorter`1<TElement> System.Linq.OrderedEnumerable`1::GetEnumerableSorter(System.Linq.EnumerableSorter`1<TElement>)
// 0x0000002F System.Collections.IEnumerator System.Linq.OrderedEnumerable`1::System.Collections.IEnumerable.GetEnumerator()
// 0x00000030 System.Linq.IOrderedEnumerable`1<TElement> System.Linq.OrderedEnumerable`1::System.Linq.IOrderedEnumerable<TElement>.CreateOrderedEnumerable(System.Func`2<TElement,TKey>,System.Collections.Generic.IComparer`1<TKey>,System.Boolean)
// 0x00000031 System.Void System.Linq.OrderedEnumerable`1::.ctor()
// 0x00000032 System.Void System.Linq.OrderedEnumerable`1/<GetEnumerator>d__1::.ctor(System.Int32)
// 0x00000033 System.Void System.Linq.OrderedEnumerable`1/<GetEnumerator>d__1::System.IDisposable.Dispose()
// 0x00000034 System.Boolean System.Linq.OrderedEnumerable`1/<GetEnumerator>d__1::MoveNext()
// 0x00000035 TElement System.Linq.OrderedEnumerable`1/<GetEnumerator>d__1::System.Collections.Generic.IEnumerator<TElement>.get_Current()
// 0x00000036 System.Void System.Linq.OrderedEnumerable`1/<GetEnumerator>d__1::System.Collections.IEnumerator.Reset()
// 0x00000037 System.Object System.Linq.OrderedEnumerable`1/<GetEnumerator>d__1::System.Collections.IEnumerator.get_Current()
// 0x00000038 System.Void System.Linq.OrderedEnumerable`2::.ctor(System.Collections.Generic.IEnumerable`1<TElement>,System.Func`2<TElement,TKey>,System.Collections.Generic.IComparer`1<TKey>,System.Boolean)
// 0x00000039 System.Linq.EnumerableSorter`1<TElement> System.Linq.OrderedEnumerable`2::GetEnumerableSorter(System.Linq.EnumerableSorter`1<TElement>)
// 0x0000003A System.Void System.Linq.EnumerableSorter`1::ComputeKeys(TElement[],System.Int32)
// 0x0000003B System.Int32 System.Linq.EnumerableSorter`1::CompareKeys(System.Int32,System.Int32)
// 0x0000003C System.Int32[] System.Linq.EnumerableSorter`1::Sort(TElement[],System.Int32)
// 0x0000003D System.Void System.Linq.EnumerableSorter`1::QuickSort(System.Int32[],System.Int32,System.Int32)
// 0x0000003E System.Void System.Linq.EnumerableSorter`1::.ctor()
// 0x0000003F System.Void System.Linq.EnumerableSorter`2::.ctor(System.Func`2<TElement,TKey>,System.Collections.Generic.IComparer`1<TKey>,System.Boolean,System.Linq.EnumerableSorter`1<TElement>)
// 0x00000040 System.Void System.Linq.EnumerableSorter`2::ComputeKeys(TElement[],System.Int32)
// 0x00000041 System.Int32 System.Linq.EnumerableSorter`2::CompareKeys(System.Int32,System.Int32)
// 0x00000042 System.Void System.Linq.Buffer`1::.ctor(System.Collections.Generic.IEnumerable`1<TElement>)
// 0x00000043 TElement[] System.Linq.Buffer`1::ToArray()
// 0x00000044 System.Void System.Collections.Generic.HashSet`1::.ctor()
// 0x00000045 System.Void System.Collections.Generic.HashSet`1::.ctor(System.Collections.Generic.IEqualityComparer`1<T>)
// 0x00000046 System.Void System.Collections.Generic.HashSet`1::.ctor(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)
// 0x00000047 System.Void System.Collections.Generic.HashSet`1::System.Collections.Generic.ICollection<T>.Add(T)
// 0x00000048 System.Void System.Collections.Generic.HashSet`1::Clear()
// 0x00000049 System.Boolean System.Collections.Generic.HashSet`1::Contains(T)
// 0x0000004A System.Void System.Collections.Generic.HashSet`1::CopyTo(T[],System.Int32)
// 0x0000004B System.Boolean System.Collections.Generic.HashSet`1::Remove(T)
// 0x0000004C System.Int32 System.Collections.Generic.HashSet`1::get_Count()
// 0x0000004D System.Boolean System.Collections.Generic.HashSet`1::System.Collections.Generic.ICollection<T>.get_IsReadOnly()
// 0x0000004E System.Collections.Generic.HashSet`1/Enumerator<T> System.Collections.Generic.HashSet`1::GetEnumerator()
// 0x0000004F System.Collections.Generic.IEnumerator`1<T> System.Collections.Generic.HashSet`1::System.Collections.Generic.IEnumerable<T>.GetEnumerator()
// 0x00000050 System.Collections.IEnumerator System.Collections.Generic.HashSet`1::System.Collections.IEnumerable.GetEnumerator()
// 0x00000051 System.Void System.Collections.Generic.HashSet`1::GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)
// 0x00000052 System.Void System.Collections.Generic.HashSet`1::OnDeserialization(System.Object)
// 0x00000053 System.Boolean System.Collections.Generic.HashSet`1::Add(T)
// 0x00000054 System.Void System.Collections.Generic.HashSet`1::CopyTo(T[])
// 0x00000055 System.Void System.Collections.Generic.HashSet`1::CopyTo(T[],System.Int32,System.Int32)
// 0x00000056 System.Void System.Collections.Generic.HashSet`1::Initialize(System.Int32)
// 0x00000057 System.Void System.Collections.Generic.HashSet`1::IncreaseCapacity()
// 0x00000058 System.Void System.Collections.Generic.HashSet`1::SetCapacity(System.Int32)
// 0x00000059 System.Boolean System.Collections.Generic.HashSet`1::AddIfNotPresent(T)
// 0x0000005A System.Int32 System.Collections.Generic.HashSet`1::InternalGetHashCode(T)
// 0x0000005B System.Void System.Collections.Generic.HashSet`1/Enumerator::.ctor(System.Collections.Generic.HashSet`1<T>)
// 0x0000005C System.Void System.Collections.Generic.HashSet`1/Enumerator::Dispose()
// 0x0000005D System.Boolean System.Collections.Generic.HashSet`1/Enumerator::MoveNext()
// 0x0000005E T System.Collections.Generic.HashSet`1/Enumerator::get_Current()
// 0x0000005F System.Object System.Collections.Generic.HashSet`1/Enumerator::System.Collections.IEnumerator.get_Current()
// 0x00000060 System.Void System.Collections.Generic.HashSet`1/Enumerator::System.Collections.IEnumerator.Reset()
static Il2CppMethodPointer s_methodPointers[96] = 
{
	Error_ArgumentNull_m0EDA0D46D72CA692518E3E2EB75B48044D8FD41E,
	Error_MoreThanOneMatch_m4C4756AF34A76EF12F3B2B6D8C78DE547F0FBCF8,
	Error_NoElements_mB89E91246572F009281D79730950808F17C3F353,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	Enumerable_Sum_m6CFC8CEAC70AE3C469A5D1993FAF8EEEC6A06FB5,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
};
static const int32_t s_InvokerIndices[96] = 
{
	3751,
	3866,
	3866,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	3689,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
};
static const Il2CppTokenRangePair s_rgctxIndices[28] = 
{
	{ 0x02000004, { 47, 4 } },
	{ 0x02000005, { 51, 9 } },
	{ 0x02000006, { 60, 7 } },
	{ 0x02000007, { 67, 10 } },
	{ 0x02000008, { 77, 1 } },
	{ 0x0200000A, { 78, 3 } },
	{ 0x0200000B, { 83, 5 } },
	{ 0x0200000C, { 88, 7 } },
	{ 0x0200000D, { 95, 3 } },
	{ 0x0200000E, { 98, 7 } },
	{ 0x0200000F, { 105, 4 } },
	{ 0x02000010, { 109, 21 } },
	{ 0x02000012, { 130, 2 } },
	{ 0x06000004, { 0, 10 } },
	{ 0x06000005, { 10, 5 } },
	{ 0x06000006, { 15, 2 } },
	{ 0x06000007, { 17, 1 } },
	{ 0x06000008, { 18, 3 } },
	{ 0x06000009, { 21, 2 } },
	{ 0x0600000A, { 23, 4 } },
	{ 0x0600000B, { 27, 4 } },
	{ 0x0600000C, { 31, 3 } },
	{ 0x0600000D, { 34, 1 } },
	{ 0x0600000E, { 35, 3 } },
	{ 0x0600000F, { 38, 2 } },
	{ 0x06000010, { 40, 2 } },
	{ 0x06000011, { 42, 5 } },
	{ 0x06000030, { 81, 2 } },
};
static const Il2CppRGCTXDefinition s_rgctxValues[132] = 
{
	{ (Il2CppRGCTXDataType)2, 1612 },
	{ (Il2CppRGCTXDataType)3, 6640 },
	{ (Il2CppRGCTXDataType)2, 2780 },
	{ (Il2CppRGCTXDataType)2, 2424 },
	{ (Il2CppRGCTXDataType)3, 11899 },
	{ (Il2CppRGCTXDataType)2, 1695 },
	{ (Il2CppRGCTXDataType)2, 2428 },
	{ (Il2CppRGCTXDataType)3, 11912 },
	{ (Il2CppRGCTXDataType)2, 2426 },
	{ (Il2CppRGCTXDataType)3, 11905 },
	{ (Il2CppRGCTXDataType)2, 554 },
	{ (Il2CppRGCTXDataType)3, 24 },
	{ (Il2CppRGCTXDataType)3, 25 },
	{ (Il2CppRGCTXDataType)2, 1069 },
	{ (Il2CppRGCTXDataType)3, 5037 },
	{ (Il2CppRGCTXDataType)2, 2136 },
	{ (Il2CppRGCTXDataType)3, 10221 },
	{ (Il2CppRGCTXDataType)3, 5517 },
	{ (Il2CppRGCTXDataType)2, 737 },
	{ (Il2CppRGCTXDataType)3, 1335 },
	{ (Il2CppRGCTXDataType)3, 1336 },
	{ (Il2CppRGCTXDataType)2, 1696 },
	{ (Il2CppRGCTXDataType)3, 6952 },
	{ (Il2CppRGCTXDataType)2, 1530 },
	{ (Il2CppRGCTXDataType)2, 1156 },
	{ (Il2CppRGCTXDataType)2, 1246 },
	{ (Il2CppRGCTXDataType)2, 1301 },
	{ (Il2CppRGCTXDataType)2, 1531 },
	{ (Il2CppRGCTXDataType)2, 1157 },
	{ (Il2CppRGCTXDataType)2, 1247 },
	{ (Il2CppRGCTXDataType)2, 1302 },
	{ (Il2CppRGCTXDataType)2, 1248 },
	{ (Il2CppRGCTXDataType)2, 1303 },
	{ (Il2CppRGCTXDataType)3, 5038 },
	{ (Il2CppRGCTXDataType)2, 1239 },
	{ (Il2CppRGCTXDataType)2, 1240 },
	{ (Il2CppRGCTXDataType)2, 1299 },
	{ (Il2CppRGCTXDataType)3, 5036 },
	{ (Il2CppRGCTXDataType)2, 1155 },
	{ (Il2CppRGCTXDataType)2, 1245 },
	{ (Il2CppRGCTXDataType)2, 1154 },
	{ (Il2CppRGCTXDataType)3, 13967 },
	{ (Il2CppRGCTXDataType)3, 4516 },
	{ (Il2CppRGCTXDataType)2, 975 },
	{ (Il2CppRGCTXDataType)2, 1242 },
	{ (Il2CppRGCTXDataType)2, 1300 },
	{ (Il2CppRGCTXDataType)2, 1357 },
	{ (Il2CppRGCTXDataType)3, 6641 },
	{ (Il2CppRGCTXDataType)3, 6643 },
	{ (Il2CppRGCTXDataType)2, 387 },
	{ (Il2CppRGCTXDataType)3, 6642 },
	{ (Il2CppRGCTXDataType)3, 6651 },
	{ (Il2CppRGCTXDataType)2, 1615 },
	{ (Il2CppRGCTXDataType)2, 2427 },
	{ (Il2CppRGCTXDataType)3, 11906 },
	{ (Il2CppRGCTXDataType)3, 6652 },
	{ (Il2CppRGCTXDataType)2, 1273 },
	{ (Il2CppRGCTXDataType)2, 1322 },
	{ (Il2CppRGCTXDataType)3, 5043 },
	{ (Il2CppRGCTXDataType)3, 13962 },
	{ (Il2CppRGCTXDataType)3, 6644 },
	{ (Il2CppRGCTXDataType)2, 1614 },
	{ (Il2CppRGCTXDataType)2, 2425 },
	{ (Il2CppRGCTXDataType)3, 11900 },
	{ (Il2CppRGCTXDataType)3, 5042 },
	{ (Il2CppRGCTXDataType)3, 6645 },
	{ (Il2CppRGCTXDataType)3, 13961 },
	{ (Il2CppRGCTXDataType)3, 6658 },
	{ (Il2CppRGCTXDataType)2, 1616 },
	{ (Il2CppRGCTXDataType)2, 2429 },
	{ (Il2CppRGCTXDataType)3, 11913 },
	{ (Il2CppRGCTXDataType)3, 7001 },
	{ (Il2CppRGCTXDataType)3, 3677 },
	{ (Il2CppRGCTXDataType)3, 5044 },
	{ (Il2CppRGCTXDataType)3, 3676 },
	{ (Il2CppRGCTXDataType)3, 6659 },
	{ (Il2CppRGCTXDataType)3, 13963 },
	{ (Il2CppRGCTXDataType)3, 5041 },
	{ (Il2CppRGCTXDataType)2, 555 },
	{ (Il2CppRGCTXDataType)3, 28 },
	{ (Il2CppRGCTXDataType)3, 10208 },
	{ (Il2CppRGCTXDataType)2, 2137 },
	{ (Il2CppRGCTXDataType)3, 10222 },
	{ (Il2CppRGCTXDataType)2, 738 },
	{ (Il2CppRGCTXDataType)3, 1337 },
	{ (Il2CppRGCTXDataType)3, 10214 },
	{ (Il2CppRGCTXDataType)3, 3648 },
	{ (Il2CppRGCTXDataType)2, 406 },
	{ (Il2CppRGCTXDataType)3, 10209 },
	{ (Il2CppRGCTXDataType)2, 2133 },
	{ (Il2CppRGCTXDataType)3, 1366 },
	{ (Il2CppRGCTXDataType)2, 752 },
	{ (Il2CppRGCTXDataType)2, 950 },
	{ (Il2CppRGCTXDataType)3, 3654 },
	{ (Il2CppRGCTXDataType)3, 10210 },
	{ (Il2CppRGCTXDataType)3, 3643 },
	{ (Il2CppRGCTXDataType)3, 3644 },
	{ (Il2CppRGCTXDataType)3, 3642 },
	{ (Il2CppRGCTXDataType)3, 3645 },
	{ (Il2CppRGCTXDataType)2, 946 },
	{ (Il2CppRGCTXDataType)2, 2845 },
	{ (Il2CppRGCTXDataType)3, 5040 },
	{ (Il2CppRGCTXDataType)3, 3647 },
	{ (Il2CppRGCTXDataType)2, 1224 },
	{ (Il2CppRGCTXDataType)3, 3646 },
	{ (Il2CppRGCTXDataType)2, 1158 },
	{ (Il2CppRGCTXDataType)2, 2805 },
	{ (Il2CppRGCTXDataType)2, 1251 },
	{ (Il2CppRGCTXDataType)2, 1304 },
	{ (Il2CppRGCTXDataType)3, 4532 },
	{ (Il2CppRGCTXDataType)2, 983 },
	{ (Il2CppRGCTXDataType)3, 5348 },
	{ (Il2CppRGCTXDataType)3, 5349 },
	{ (Il2CppRGCTXDataType)3, 5354 },
	{ (Il2CppRGCTXDataType)2, 1365 },
	{ (Il2CppRGCTXDataType)3, 5351 },
	{ (Il2CppRGCTXDataType)3, 14377 },
	{ (Il2CppRGCTXDataType)2, 953 },
	{ (Il2CppRGCTXDataType)3, 3668 },
	{ (Il2CppRGCTXDataType)1, 1219 },
	{ (Il2CppRGCTXDataType)2, 2813 },
	{ (Il2CppRGCTXDataType)3, 5350 },
	{ (Il2CppRGCTXDataType)1, 2813 },
	{ (Il2CppRGCTXDataType)1, 1365 },
	{ (Il2CppRGCTXDataType)2, 2863 },
	{ (Il2CppRGCTXDataType)2, 2813 },
	{ (Il2CppRGCTXDataType)3, 5355 },
	{ (Il2CppRGCTXDataType)3, 5353 },
	{ (Il2CppRGCTXDataType)3, 5352 },
	{ (Il2CppRGCTXDataType)2, 283 },
	{ (Il2CppRGCTXDataType)3, 3678 },
	{ (Il2CppRGCTXDataType)2, 393 },
};
extern const CustomAttributesCacheGenerator g_System_Core_AttributeGenerators[];
IL2CPP_EXTERN_C const Il2CppCodeGenModule g_System_Core_CodeGenModule;
const Il2CppCodeGenModule g_System_Core_CodeGenModule = 
{
	"System.Core.dll",
	96,
	s_methodPointers,
	0,
	NULL,
	s_InvokerIndices,
	0,
	NULL,
	28,
	s_rgctxIndices,
	132,
	s_rgctxValues,
	NULL,
	g_System_Core_AttributeGenerators,
	NULL, // module initializer,
	NULL,
	NULL,
	NULL,
};
