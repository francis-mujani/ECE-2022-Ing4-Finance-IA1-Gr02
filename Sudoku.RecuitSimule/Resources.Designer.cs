﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sudoku.RecuitSimule {
    using System;
    
    
    /// <summary>
    ///   Une classe de ressource fortement typée destinée, entre autres, à la consultation des chaînes localisées.
    /// </summary>
    // Cette classe a été générée automatiquement par la classe StronglyTypedResourceBuilder
    // à l'aide d'un outil, tel que ResGen ou Visual Studio.
    // Pour ajouter ou supprimer un membre, modifiez votre fichier .ResX, puis réexécutez ResGen
    // avec l'option /str ou régénérez votre projet VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Retourne l'instance ResourceManager mise en cache utilisée par cette classe.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Sudoku.RecuitSimule.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Remplace la propriété CurrentUICulture du thread actuel pour toutes
        ///   les recherches de ressources à l'aide de cette classe de ressource fortement typée.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à import random
        ///import numpy as np
        ///import math 
        ///from random import choice
        ///import statistics 
        ///
        ///#sudoku instance, we use &apos;0&apos; for empty cells
        ///#instance = ((0,2,4,0,0,7,0,0,0),
        ///#            (6,0,0,0,0,0,0,0,0),
        ///#            (0,0,3,6,8,0,4,1,5),
        ///#            (4,3,1,0,0,5,0,0,0),
        ///#            (5,0,0,0,0,0,0,3,2),
        ///#            (7,9,0,0,0,0,0,6,0),
        ///#            (2,0,9,7,1,0,8,0,0),
        ///#            (0,4,0,0,9,3,0,0,0),
        ///#            (3,1,0,0,0,4,7,5,0))
        ///
        ///sudoku = np.asarray(instance)
        ///
        ///
        ///def FixSudokuVal [le reste de la chaîne a été tronqué]&quot;;.
        /// </summary>
        internal static string RecuitSimuleSolver_py {
            get {
                return ResourceManager.GetString("RecuitSimuleSolver.py", resourceCulture);
            }
        }
        internal static string RecuitSimuleSolver2_py
        {
            get
            {
                return ResourceManager.GetString("RecuitSimuleSolver2.py", resourceCulture);
            }
        }
    }
}
