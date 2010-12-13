﻿namespace CruiseControl.Core
{
    /// <summary>
    /// An item of server configuration - this is typically a structure item.
    /// </summary>
    public abstract class ServerItem
    {
        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="ServerItem"/> class.
        /// </summary>
        protected ServerItem()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerItem"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        protected ServerItem(string name)
        {
            this.Name = name;
        }
        #endregion

        #region Public properties
        #region Name
        /// <summary>
        /// Gets or sets the name of the item.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; set; }
        #endregion

        #region ItemType
        /// <summary>
        /// Gets the type of the item.
        /// </summary>
        /// <value>
        /// The type of the item.
        /// </value>
        public virtual string ItemType
        {
            get { return this.GetType().Name; }
        }
        #endregion
        #endregion

        #region Public methods
        #region AskToIntegrate()
        /// <summary>
        /// Asks if an item can integrate.
        /// </summary>
        /// <param name="context">The context to use.</param>
        public abstract void AskToIntegrate(IntegrationContext context);
        #endregion
        #endregion
    }
}