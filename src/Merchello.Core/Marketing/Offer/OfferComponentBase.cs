﻿namespace Merchello.Core.Marketing.Offer
{
    using System;

    using Umbraco.Core;

    /// <summary>
    /// Base class for offer constraints.
    /// </summary>
    public abstract class OfferComponentBase
    {
        /// <summary>
        /// The <see cref="OfferComponentDefinition"/>.
        /// </summary>
        private readonly OfferComponentDefinition _definition;

        /// <summary>
        /// Initializes a new instance of the <see cref="OfferComponentBase"/> class.
        /// </summary>
        /// <param name="definition">
        /// The <see cref="OfferComponentDefinition"/>.
        /// </param>
        protected OfferComponentBase(OfferComponentDefinition definition)
        {
            Mandate.ParameterNotNull(definition, "definition");

            this._definition = definition;
        }

        /// <summary>
        /// Gets the component type.
        /// </summary>
        public abstract OfferComponentType ComponentType { get; }


        /// <summary>
        /// Gets the Type this component is responsible for building
        /// </summary>
        internal abstract Type BuilderFor { get; }

        /// <summary>
        /// Gets the <see cref="OfferComponentDefinition"/>.
        /// </summary>
        internal OfferComponentDefinition OfferComponentDefinition
        {
            get
            {
                return this._definition;
            }
        }
    }
}