---
title: "IEnumDebugFields::Skip | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "IEnumDebugFields::Skip"
helpviewer_keywords:
  - "IEnumDebugFields::Skip method"
ms.assetid: b3bc51c4-21ae-4913-800c-c2ca9dc18443
author: "gregvanl"
ms.author: "gregvanl"
manager: jillfra
ms.workload:
  - "vssdk"
---
# IEnumDebugFields::Skip
This method skips over the specified number of elements.

## Syntax

```cpp
HRESULT Skip(
   ULONG celt
);
```

```csharp
int Skip(
   uint celt
);
```

#### Parameters
 `celt`

 [in] Number of elements to skip.

## Return Value
 If successful, returns `S_OK`. Returns `S_FALSE` if `celt` is greater than the number of remaining elements; otherwise, returns an error code.

## Remarks
 If `celt` specifies a value greater than the number of remaining elements, the enumeration is set to the end and `S_FALSE` is returned.

## See Also
- [IEnumDebugFields](../../../extensibility/debugger/reference/ienumdebugfields.md)