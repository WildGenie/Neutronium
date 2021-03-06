﻿using System;
using System.Collections.Generic;

namespace Neutronium.Core.WebBrowserEngine.JavascriptObject
{
    /// <summary>
    /// Factory to create IJavascriptObject
    /// </summary>
    public interface IJavascriptObjectFactory 
    {
        /// <summary>
        /// Create IJavascriptObject from basic CLR types
        /// </summary>
        /// <param name="from">
        /// object to be converted
        /// </param>
        /// <param name="res">
        /// IJavascriptObject converted from <paramref name="from" />
        /// </param>
        /// <returns>
        /// true if the IJavascriptObject has been created
        ///</returns>
        bool CreateBasic(object from, out IJavascriptObject res);

        /// <summary>
        /// Indicates if a type is a basic CLR type which
        /// can be converted with SolveBasic
        /// </summary>
        /// <param name="type">
        /// Type to check
        /// </param>
        /// <returns>
        /// true if type can be handled by SolveBasic
        ///</returns>
        bool IsTypeBasic(Type type);

        /// <summary>
        /// Create IJavascriptObject representing null value
        /// </summary>
        /// <returns>
        /// corresponding IJavascriptObject
        ///</returns>
        IJavascriptObject CreateNull();

        /// <summary>
        /// Create IJavascriptObject object
        /// </summary>   
        /// <param name="local">
        /// true if local object, meaning browser context. 
        /// </param>
        /// <returns>
        /// corresponding IJavascriptObject
        ///</returns>
        IJavascriptObject CreateObject(bool local);

        /// <summary>
        /// Create IJavascriptObject object from javascript code
        /// </summary>   
        /// <param name="creationCode">
        /// the javascript code to create the object
        /// </param>
        /// <returns>
        /// corresponding IJavascriptObject
        ///</returns>
        IJavascriptObject CreateObject(string creationCode);

        /// <summary>
        /// Create IJavascriptObject corresponding to undefined
        /// </summary>   
        IJavascriptObject CreateUndefined();

        /// <summary>
        /// Create IJavascriptObject from an int
        /// </summary>
        /// <param name="value">
        /// int to be converted
        /// </param>
        /// <returns>
        /// corresponding IJavascriptObject
        ///</returns>
        IJavascriptObject CreateInt(int value);

        /// <summary>
        /// Create IJavascriptObject from an double
        /// </summary>
        /// <param name="value">
        /// double to be converted
        /// </param>
        /// <returns>
        /// corresponding IJavascriptObject
        ///</returns>
        IJavascriptObject CreateDouble(double value);


        /// <summary>
        /// Create IJavascriptObject from an string
        /// </summary>
        /// <param name="value">
        /// string to be converted
        /// </param>
        /// <returns>
        /// corresponding IJavascriptObject
        ///</returns>
        IJavascriptObject CreateString(string value);


        /// <summary>
        /// Create IJavascriptObject from a boolean
        /// </summary>
        /// <param name="value">
        /// boolean to be converted
        /// </param>
        /// <returns>
        /// corresponding IJavascriptObject
        ///</returns>
        IJavascriptObject CreateBool(bool value);

        /// <summary>
        /// Create IJavascriptObject list
        /// </summary>
        /// <param name="collection">
        /// the elements of the collection
        /// </param>
        /// <returns>
        /// corresponding IJavascriptObject
        ///</returns>
        IJavascriptObject CreateArray(IEnumerable<IJavascriptObject> collection);

        /// <summary>
        /// Create IJavascriptObject list
        /// </summary>
        /// <param name="size">
        /// the size of the collection
        /// </param>
        /// <returns>
        /// corresponding IJavascriptObject
        ///</returns>
        IJavascriptObject CreateArray(int size);
    }
}
