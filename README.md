# Article 2: Retrieving and Using Type Information

## Introduction

Welcome to the second article in our series on **Understanding .NET Reflection**. In this article, we will delve into the topic of retrieving and using type information using the .NET Reflection framework. We'll walk you through a detailed example that showcases how to access type details, explore constructors and methods, and retrieve property and field information using reflection.

## Table of Contents

- [Introduction](#introduction)
- [Usage](#usage)

## English

### Introduction

.NET Reflection is a powerful feature that allows you to inspect and interact with the metadata and structure of types at runtime. This capability enables dynamic analysis, manipulation, and utilization of types, methods, properties, and more, without the need for compile-time knowledge of the classes involved. This article focuses on using reflection to retrieve various type-related details and demonstrates a basic example of creating instances using reflection.

### Usage

Follow these steps to explore the code example provided in the `Program.cs` file:

1. **Accessing Type Information:**
    - We use the `Type` class from the `System.Reflection` namespace to access information about the `Order` type from the `ReflectionIntroLibrary` assembly.
    - The type's name, namespace, and assembly details are retrieved and displayed using reflection.

    ```csharp
    // Accessing type information
    Type orderType = typeof(ReflectionIntroLibrary.Order);
    Console.WriteLine($"Type Name: {orderType.FullName}");
    Console.WriteLine($"Namespace: {orderType.Namespace}");
    Console.WriteLine($"Assembly: {orderType.Assembly.FullName}");
    ```

2. **Creating Instances Using Reflection:**
    - We demonstrate how to create an instance of the `Order` type dynamically using `Activator.CreateInstance`.
    - PropertyInfo instances are obtained for the `OrderId` and `OrderedProduct` properties of the `Order` type.
    - The value of the `OrderId` property is set to 101 using reflection.
    
    ```csharp
    // Creating an instance of Order using reflection
    object orderInstance = Activator.CreateInstance(orderType);
    ...
    ```

3. **Creating Instances of Nested Type Using Reflection:**
    - We create an instance of the nested type `Product` within the `Order` type using `Activator.CreateInstance`.
    - PropertyInfo is obtained for the `Name` property of the `Product` type.
    - The value of the `Name` property of the `Product` instance is set to "Example Product" using reflection.
    - The `Product` instance is assigned to the `OrderedProduct` property of the `Order` instance.
    ...

4. **Retrieving Property Values Using Reflection:**
    - The values of the `OrderId` property of the `Order` instance and the `Name` property of the `Product` instance are retrieved using reflection.
    ...

5. **Exploring Other Reflection Features:**
    - While this example focuses on type information and dynamic instance creation, reflection offers even more capabilities, such as inspecting methods, constructors, fields, and attributes dynamically.
    ...

By following along with this example, you'll gain a solid understanding of how to leverage reflection to access type information, create instances dynamically, and interact with properties of types.

**Please note:** Reflection can incur performance overhead, so it's essential to use it judiciously and consider its implications on your application's performance.

Feel free to experiment with the code and explore other reflection-related functionalities as you dive deeper into .NET Reflection.

## License

This project is licensed under the [MIT License](LICENSE.txt).

---
## Español

### Introducción

Bienvenido al segundo artículo de nuestra serie sobre **Comprendiendo la Reflexión en .NET**. En este artículo, profundizaremos en el tema de cómo recuperar y utilizar información de tipos utilizando el marco de trabajo de Reflexión en .NET. Te guiaremos a través de un ejemplo detallado que muestra cómo acceder a los detalles del tipo, explorar constructores y métodos, y recuperar información de propiedades y campos utilizando la reflexión.

### Uso

Sigue estos pasos para explorar el ejemplo de código proporcionado en el archivo `Program.cs`:

1. **Acceso a la Información del Tipo:**
    - Usamos la clase `Type` del espacio de nombres `System.Reflection` para acceder a la información sobre el tipo `Order` del ensamblado `ReflectionIntroLibrary`.
    - Los detalles del nombre del tipo, espacio de nombres y ensamblado se recuperan y muestran utilizando la reflexión.

    ```csharp
    // Acceso a la información del tipo
    Type orderType = typeof(ReflectionIntroLibrary.Order);
    Console.WriteLine($"Nombre del Tipo: {orderType.FullName}");
    Console.WriteLine($"Espacio de Nombres: {orderType.Namespace}");
    Console.WriteLine($"Ensamblado: {orderType.Assembly.FullName}");
    ```

2. **Creación de Instancias Usando la Reflexión:**
    - Demostramos cómo crear dinámicamente una instancia del tipo `Order` utilizando `Activator.CreateInstance`.
    - Se obtienen instancias de PropertyInfo para las propiedades `OrderId` y `OrderedProduct` del tipo `Order`.
    - El valor de la propiedad `OrderId` se establece en 101 utilizando la reflexión.
    
    ```csharp
    // Creación de una instancia de Order utilizando la reflexión
    object orderInstance = Activator.CreateInstance(orderType);
    ...
    ```

3. **Creación de Instancias de un Tipo Anidado Usando la Reflexión:**
    - Creamos una instancia del tipo anidado `Product` dentro del tipo `Order` utilizando `Activator.CreateInstance`.
    - Se obtiene PropertyInfo para la propiedad `Name` del tipo `Product`.
    - El valor de la propiedad `Name` de la instancia de `Product` se establece en "Producto de Ejemplo" utilizando la reflexión.
    - La instancia de `Product` se asigna a la propiedad `OrderedProduct` de la instancia de `Order`.
    ...

4. **Recuperación de Valores de Propiedades Usando la Reflexión:**
    - Los valores de la propiedad `OrderId` de la instancia de `Order` y la propiedad `Name` de la instancia de `Product` se recuperan utilizando la reflexión.
    ...

5. **Exploración de Otras Funcionalidades de la Reflexión:**
    - Si bien este ejemplo se centra en la información del tipo y la creación dinámica de instancias, la reflexión ofrece aún más capacidades, como inspeccionar métodos, constructores, campos y atributos de manera dinámica.
    ...

Siguiendo este ejemplo, obtendrás una comprensión sólida de cómo aprovechar la reflexión para acceder a la información del tipo, crear instancias de manera dinámica e interactuar con las propiedades de los tipos.

**Ten en cuenta:** La reflexión puede tener un impacto en el rendimiento, por lo que es esencial usarla con prudencia y considerar sus implicaciones en el rendimiento de tu aplicación.

Siéntete libre de experimentar con el código y explorar otras funcionalidades relacionadas con la reflexión a medida que profundices en la Reflexión .NET.

## Licencia

Este proyecto está bajo la [Licencia MIT](LICENSE.txt).

---
## Français

### Introduction

Bienvenue dans le deuxième article de notre série sur **La compréhension de la Réflexion .NET**. Dans cet article, nous aborderons le sujet de la récupération et de l'utilisation d'informations sur les types à l'aide du framework de Réflexion .NET. Nous vous guiderons à travers un exemple détaillé qui met en évidence comment accéder aux détails des types, explorer les constructeurs et les méthodes, et récupérer des informations sur les propriétés et les champs à l'aide de la réflexion.

### Utilisation

Suivez ces étapes pour explorer l'exemple de code fourni dans le fichier `Program.cs` :

1. **Accès aux Informations sur les Types :**
    - Nous utilisons la classe `Type` de l'espace de noms `System.Reflection` pour accéder aux informations sur le type `Order` à partir de l'assemblage `ReflectionIntroLibrary`.
    - Les détails du nom du type, de l'espace de noms et de l'assemblage sont récupérés et affichés à l'aide de la réflexion.

    ```csharp
    // Accès aux informations sur le type
    Type orderType = typeof(ReflectionIntroLibrary.Order);
    Console.WriteLine($"Nom du Type : {orderType.FullName}");
    Console.WriteLine($"Espace de Noms : {orderType.Namespace}");
    Console.WriteLine($"Assemblage : {orderType.Assembly.FullName}");
    ```

2. **Création d'Instances à l'Aide de la Réflexion :**
    - Nous démontrons comment créer dynamiquement une instance du type `Order` à l'aide de `Activator.CreateInstance`.
    - Des instances de PropertyInfo sont obtenues pour les propriétés `OrderId` et `OrderedProduct` du type `Order`.
    - La valeur de la propriété `OrderId` est définie sur 101 à l'aide de la réflexion.
    
    ```csharp
    // Création d'une instance de Order à l'aide de la réflexion
    object orderInstance = Activator.CreateInstance(orderType);
    ...
    ```

3. **Création d'Instances d'un Type Emboîté à l'Aide de la Réflexion :**
    - Nous créons une instance du type emboîté `Product` dans le type `Order` à l'aide de `Activator.CreateInstance`.
    - PropertyInfo est obtenue pour la propriété `Name` du type `Product`.
    - La valeur de la propriété `Name` de l'instance de `Product` est définie sur "Produit Exemple" à l'aide de la réflexion.
    - L'instance de `Product` est attribuée à la propriété `OrderedProduct` de l'instance de `Order`.
    ...

4. **Récupération de Valeurs de Propriétés à l'Aide de la Réflexion :**
    - Les valeurs de la propriété `OrderId` de l'instance de `Order` et de la propriété `Name` de l'instance de `Product` sont récupérées à l'aide de la réflexion.
    ...

5. **Exploration d'Autres Fonctionnalités de la Réflexion :**
    - Bien que cet exemple se concentre sur les informations sur les types et la création dynamique d'instances, la réflexion offre encore plus de fonctionnalités, comme l'inspection dynamique des méthodes, des constructeurs, des champs et des attributs.
    ...

En suivant cet exemple, vous obtiendrez une compréhension solide de la manière d'utiliser la réflexion pour accéder aux informations sur les types, créer des instances de manière dynamique et interagir avec les propriétés des types.

**Veuillez noter :** La réflexion peut entraîner une surcharge des performances, il est donc essentiel de l'utiliser avec discernement et de tenir compte de ses implications sur les performances de votre application.

N'hésitez pas à expérimenter avec le code et à explorer d'autres fonctionnalités liées à la réflexion en plongeant plus profondément dans la Réflexion .NET.

## Licence

Ce projet est sous licence [MIT](LICENSE.txt).

---
